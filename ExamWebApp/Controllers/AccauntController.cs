using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ExamWebApp.DAL;
using ExamWebApp.Models;
using ExamWebApp.Utilities;
using ExamWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ExamWebApp.Controllers
{
   
    public class AccauntController : Controller
    {
        private ExamDbContext _db;
        private UserManager<Worker> _userManager;
        private SignInManager<Worker> _signManager;
        private RoleManager<IdentityRole> _roleManager;
        private ILogger<AccauntController> _logger;
        private IConfiguration _configuration;

        public AccauntController(ExamDbContext examdb, UserManager<Worker> user, RoleManager<IdentityRole> roleManager,
           SignInManager<Worker> signInManager, ILogger<AccauntController> logger, IConfiguration cofiguration)
        {
            _db = examdb;
            _userManager = user;
            _signManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _configuration = cofiguration;
        }   

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (registerViewModel == null)
            {
                return View(registerViewModel);
            }

            Worker _user = new Worker()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                UserName = registerViewModel.Username,
                Email = registerViewModel.Email,
                Deleted = false,
                Password = registerViewModel.Password
            };
            IdentityResult identityResult = await _userManager.CreateAsync(_user, registerViewModel.Password);
            await _userManager.AddToRoleAsync(_user, Utility.Roles.Member.ToString());
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerViewModel);
            }

            try
            {
                string emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(_user);
                #region Email Confirmation
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(_configuration["SmtpClientCredentialEmail"], _configuration["SmtpClientCredentialPassword"]);
                MailMessage message = new MailMessage(_configuration["SmtpClientCredentialEmail"], registerViewModel.Email);
                message.IsBodyHtml = true;
                message.Subject = "Emailinizi Tesdiqleyin";
                message.Body = $"<a href=`https://localhost:44351//accaunt/confirmemail?userId={_user.Id}&token={emailConfirmationToken}`> Please Confirm Your Email password</a>";
                await client.SendMailAsync(message);
                #endregion
            }
            catch (Exception)
            {
                throw;
            };
            return RedirectToAction("Login", "Accaunt");
        }
        public async Task<IActionResult> Confirmemail(string userId, string token)
        {
            if (userId == null)
            {
                return RedirectToAction("ConfirmEmailError", "Accaunt");
            }
            if (token == null)
            {
                return RedirectToAction("ConfirmEmailError", "Accaunt");
            }
            Worker userdb = await _userManager.FindByIdAsync(userId);
            if (userdb == null)
            {
                return RedirectToAction("ConfirmEmailError", "Accaunt");
            }
            userdb.EmailConfirmed = true;
            await _userManager.UpdateAsync(userdb);
            TempData["AccountConfirmed"] = true;


            await _signManager.SignInAsync(userdb, true);

            return RedirectToAction("Login", "Accaunt");
        }

        public async Task RoleSeedrUserStatus()
        {
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Member.ToString()));
            }

        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);
            Worker find = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (find == null)
            {
                ModelState.AddModelError("", "Email don't exist in database");
                return View(loginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult login = await _signManager.PasswordSignInAsync(find, loginViewModel.Password, loginViewModel.RememberMe, true);

            if (!login.Succeeded)
            {
                ModelState.AddModelError("", "Email don't exist in database");
                return View(loginViewModel);
            }

            return RedirectToAction("Index", "Examine");
        }

        public IActionResult ConfirmEmailError()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPassword forget)
        {
            if (!ModelState.IsValid) return View(forget);
            Worker user = await _userManager.FindByEmailAsync(forget.Email);

            bool username = user.UserName != forget.UserName;
            bool name = user.Name != forget.Name;
            bool surname = user.Surname != forget.Surname;

            if (username || name || surname)
            {
                return View(forget);
            }

            string resetoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            IdentityResult _result = await _userManager.ResetPasswordAsync(user, resetoken, forget.Password);

            if (!_result.Succeeded)
            {
                foreach (var error in _result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(forget);
            }

            user.Password = forget.Password;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassword change)
        {
            Worker user = await _userManager.FindByEmailAsync(change.Email);
            bool flag = await _userManager.CheckPasswordAsync(user, change.OldPassword);
            if (!flag)
            {
                return View(change);
            }

            IdentityResult result = await _userManager.ChangePasswordAsync(user, change.OldPassword, change.NewPassword);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(change);
            }
            user.Password = change.NewPassword;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}