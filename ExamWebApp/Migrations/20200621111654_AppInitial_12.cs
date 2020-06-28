using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWebApp.Migrations
{
    public partial class AppInitial_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "105b597b-8305-4cfc-ab83-3a05ae930fb0");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "3dfc277c-235d-41f3-8ddc-1e8a5254a837");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "5b53eb7c-6d4a-4c64-81d2-dd6f14e00213");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "60d2034e-7e79-4600-b4ab-ce7897ba382e");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "ac6f4ff0-b8bc-40d5-968a-e5cd326090d5");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "c5c0baeb-1025-4125-9b40-aecac44dcd9e");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "3c6b4431-bf92-4d7c-bc85-6e7fcccf5782");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "43434857-0a25-4634-bd37-7f52ed3ffc5d");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "4e5000db-23c6-486f-9184-e03b0823421b");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "51da4f60-5dfa-4625-93d7-acfecf53e88b");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "63e6f5c4-d2b5-48f2-94bd-18d1838aae76");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "98be51c7-ca69-4c0e-8fdb-2120476da858");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "a766af06-acd9-4dda-80ce-89e75bf46041");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "b2b85b59-318d-4fe0-a59d-c5f71bef05d2");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "dad8511a-b590-4d7a-82ef-c1d24b1c6f62");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "dc938e8c-ef05-4dc2-ad1e-71bbb302975c");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "de209d0e-016b-46f1-a3a1-c3e6b037aade");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "07113265-8f60-4cc7-a004-f120515c7f7c");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "11a52b6a-eca8-417c-82d3-67c9f4d2aa2c");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "22e89eca-f64f-4f00-958a-df321d5a9a77");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "3927a7e1-ebb5-4e56-af4e-c4e3f69b29b0");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "3aa0e748-51e5-4cca-9bdf-dfa94aafaa9a");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "48161623-8f57-491e-a51a-dbd8835b4336");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "599d1f4d-2719-474e-85d6-44c1c59d6e9f");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "6cd74d09-feea-48c7-8614-d7987cb99630");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "84deca78-2d6e-46ee-99e3-9cec47a988b5");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "aba1e1ce-ff17-4dd3-8ab6-a3f4c7a3b282");

            migrationBuilder.AlterColumn<string>(
                name: "ExamDay",
                table: "Exams",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "Letter", "MaxGrade", "MinGrade" },
                values: new object[,]
                {
                    { "b3254576-be44-4a4f-bb2c-665f5b89c935", "A", (byte)100, (byte)91 },
                    { "55792e08-4bd0-4b80-b777-a4f5798e160a", "B", (byte)90, (byte)81 },
                    { "6d8e2216-138b-42b2-a001-9df60a21b2ca", "C", (byte)80, (byte)71 },
                    { "f384726d-126e-44ed-9010-0e9bf3dbb24c", "D", (byte)70, (byte)61 },
                    { "b7227970-b1ba-4f1f-9219-9aaa40b71647", "E", (byte)60, (byte)51 },
                    { "29c4861d-1bb3-47f7-ad65-118908c2c21d", "F", (byte)50, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "SchoolClassId", "Nth" },
                values: new object[,]
                {
                    { "81d3fb6e-5101-4795-848d-3f1be65cfa92", "Eleventh" },
                    { "25425cff-bf62-4ab7-99a4-f6913b9e1a8d", "Tenth" },
                    { "0f587bd7-e5d3-4867-bde4-4d41c8855b9a", "Ninth" },
                    { "599fe92a-9d87-44f9-96a3-5fe09b93a70f", "Seventh" },
                    { "e574d694-3080-48a3-8468-7f03f7060435", "Sixth" },
                    { "ab3be4dd-4cf7-4140-8620-6a2d81b41273", "Eighth" },
                    { "eb32e50d-7672-448e-9d41-b63922bb6af5", "Fourth" },
                    { "1926320c-4f68-4ee9-9d11-96490247b98c", "Third" },
                    { "ffb9d291-cfc0-446f-a709-06ef6ec066d9", "Second" },
                    { "e4d67924-dab2-41dd-b190-73e01e481890", "First" },
                    { "51d211c5-3e8f-48a4-86a2-d990d8d64516", "Fifth" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name" },
                values: new object[,]
                {
                    { "5018163c-4370-405e-b81d-ac9b883aea57", "Cəbr" },
                    { "3bf01a19-116a-447b-bbd4-a6defb9b6e7e", "AnaDili" },
                    { "653268e8-2bdb-4519-aeaf-ec36f44a60d1", "Ədəbiyyat" },
                    { "21b4bd7d-234c-4b3e-becc-7b6f2be8fdd3", "Tarix" },
                    { "99fe023f-9726-4d52-9fa8-b02a69c32b84", "Rus_Dili" },
                    { "ea272dea-bb8d-4071-9011-2d9d65a87a4a", "Ingilis_Dili" },
                    { "0d3ccf00-9cab-43a3-9ce3-5c7a0c263b73", "Fizika" },
                    { "effba506-a163-4fa3-afce-235e75b8f48e", "Coğrayiya" },
                    { "09682ec6-67d1-4e92-9979-1c55d0820249", "Kimya" },
                    { "a4d98e33-fcbc-4d5b-b0a2-379758900c7f", "Həndəsə" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "29c4861d-1bb3-47f7-ad65-118908c2c21d");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "55792e08-4bd0-4b80-b777-a4f5798e160a");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "6d8e2216-138b-42b2-a001-9df60a21b2ca");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "b3254576-be44-4a4f-bb2c-665f5b89c935");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "b7227970-b1ba-4f1f-9219-9aaa40b71647");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: "f384726d-126e-44ed-9010-0e9bf3dbb24c");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "0f587bd7-e5d3-4867-bde4-4d41c8855b9a");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "1926320c-4f68-4ee9-9d11-96490247b98c");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "25425cff-bf62-4ab7-99a4-f6913b9e1a8d");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "51d211c5-3e8f-48a4-86a2-d990d8d64516");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "599fe92a-9d87-44f9-96a3-5fe09b93a70f");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "81d3fb6e-5101-4795-848d-3f1be65cfa92");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "ab3be4dd-4cf7-4140-8620-6a2d81b41273");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "e4d67924-dab2-41dd-b190-73e01e481890");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "e574d694-3080-48a3-8468-7f03f7060435");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "eb32e50d-7672-448e-9d41-b63922bb6af5");

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "SchoolClassId",
                keyValue: "ffb9d291-cfc0-446f-a709-06ef6ec066d9");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "09682ec6-67d1-4e92-9979-1c55d0820249");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "0d3ccf00-9cab-43a3-9ce3-5c7a0c263b73");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "21b4bd7d-234c-4b3e-becc-7b6f2be8fdd3");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "3bf01a19-116a-447b-bbd4-a6defb9b6e7e");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "5018163c-4370-405e-b81d-ac9b883aea57");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "653268e8-2bdb-4519-aeaf-ec36f44a60d1");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "99fe023f-9726-4d52-9fa8-b02a69c32b84");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "a4d98e33-fcbc-4d5b-b0a2-379758900c7f");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "ea272dea-bb8d-4071-9011-2d9d65a87a4a");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "effba506-a163-4fa3-afce-235e75b8f48e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamDay",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "Letter", "MaxGrade", "MinGrade" },
                values: new object[,]
                {
                    { "c5c0baeb-1025-4125-9b40-aecac44dcd9e", "A", (byte)100, (byte)91 },
                    { "ac6f4ff0-b8bc-40d5-968a-e5cd326090d5", "B", (byte)90, (byte)81 },
                    { "60d2034e-7e79-4600-b4ab-ce7897ba382e", "C", (byte)80, (byte)71 },
                    { "105b597b-8305-4cfc-ab83-3a05ae930fb0", "D", (byte)70, (byte)61 },
                    { "3dfc277c-235d-41f3-8ddc-1e8a5254a837", "E", (byte)60, (byte)51 },
                    { "5b53eb7c-6d4a-4c64-81d2-dd6f14e00213", "F", (byte)50, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "SchoolClassId", "Nth" },
                values: new object[,]
                {
                    { "3c6b4431-bf92-4d7c-bc85-6e7fcccf5782", "Eleventh" },
                    { "43434857-0a25-4634-bd37-7f52ed3ffc5d", "Tenth" },
                    { "98be51c7-ca69-4c0e-8fdb-2120476da858", "Ninth" },
                    { "51da4f60-5dfa-4625-93d7-acfecf53e88b", "Seventh" },
                    { "4e5000db-23c6-486f-9184-e03b0823421b", "Sixth" },
                    { "de209d0e-016b-46f1-a3a1-c3e6b037aade", "Eighth" },
                    { "dc938e8c-ef05-4dc2-ad1e-71bbb302975c", "Fourth" },
                    { "63e6f5c4-d2b5-48f2-94bd-18d1838aae76", "Third" },
                    { "b2b85b59-318d-4fe0-a59d-c5f71bef05d2", "Second" },
                    { "dad8511a-b590-4d7a-82ef-c1d24b1c6f62", "First" },
                    { "a766af06-acd9-4dda-80ce-89e75bf46041", "Fifth" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name" },
                values: new object[,]
                {
                    { "599d1f4d-2719-474e-85d6-44c1c59d6e9f", "Cəbr" },
                    { "11a52b6a-eca8-417c-82d3-67c9f4d2aa2c", "AnaDili" },
                    { "84deca78-2d6e-46ee-99e3-9cec47a988b5", "Ədəbiyyat" },
                    { "48161623-8f57-491e-a51a-dbd8835b4336", "Tarix" },
                    { "3aa0e748-51e5-4cca-9bdf-dfa94aafaa9a", "Rus_Dili" },
                    { "07113265-8f60-4cc7-a004-f120515c7f7c", "Ingilis_Dili" },
                    { "3927a7e1-ebb5-4e56-af4e-c4e3f69b29b0", "Fizika" },
                    { "22e89eca-f64f-4f00-958a-df321d5a9a77", "Coğrayiya" },
                    { "6cd74d09-feea-48c7-8614-d7987cb99630", "Kimya" },
                    { "aba1e1ce-ff17-4dd3-8ab6-a3f4c7a3b282", "Həndəsə" }
                });
        }
    }
}
