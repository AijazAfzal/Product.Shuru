using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_SurveyResponse_SurveyResponseId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Survey_SurveyId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Survey_Users_UserId",
                table: "Survey");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyResponse_Respondent_RespondentId",
                table: "SurveyResponse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyResponse",
                table: "SurveyResponse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Survey",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Respondent",
                table: "Respondent");

            migrationBuilder.RenameTable(
                name: "SurveyResponse",
                newName: "SurveyResponses");

            migrationBuilder.RenameTable(
                name: "Survey",
                newName: "Surveys");

            migrationBuilder.RenameTable(
                name: "Respondent",
                newName: "Respondents");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyResponse_RespondentId",
                table: "SurveyResponses",
                newName: "IX_SurveyResponses_RespondentId");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_UserId",
                table: "Surveys",
                newName: "IX_Surveys_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyResponses",
                table: "SurveyResponses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respondents",
                table: "Respondents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_SurveyResponses_SurveyResponseId",
                table: "Answers",
                column: "SurveyResponseId",
                principalTable: "SurveyResponses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyResponses_Respondents_RespondentId",
                table: "SurveyResponses",
                column: "RespondentId",
                principalTable: "Respondents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Users_UserId",
                table: "Surveys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_SurveyResponses_SurveyResponseId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyResponses_Respondents_RespondentId",
                table: "SurveyResponses");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Users_UserId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyResponses",
                table: "SurveyResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Respondents",
                table: "Respondents");

            migrationBuilder.RenameTable(
                name: "Surveys",
                newName: "Survey");

            migrationBuilder.RenameTable(
                name: "SurveyResponses",
                newName: "SurveyResponse");

            migrationBuilder.RenameTable(
                name: "Respondents",
                newName: "Respondent");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_UserId",
                table: "Survey",
                newName: "IX_Survey_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyResponses_RespondentId",
                table: "SurveyResponse",
                newName: "IX_SurveyResponse_RespondentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Survey",
                table: "Survey",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyResponse",
                table: "SurveyResponse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respondent",
                table: "Respondent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_SurveyResponse_SurveyResponseId",
                table: "Answers",
                column: "SurveyResponseId",
                principalTable: "SurveyResponse",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Survey_SurveyId",
                table: "Questions",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Survey_Users_UserId",
                table: "Survey",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyResponse_Respondent_RespondentId",
                table: "SurveyResponse",
                column: "RespondentId",
                principalTable: "Respondent",
                principalColumn: "Id");
        }
    }
}
