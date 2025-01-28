using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace restfulback.Migrations
{
    /// <inheritdoc />
    public partial class initializingd88 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MorgueLocation",
                table: "DeceasedProfiles");

            migrationBuilder.RenameColumn(
                name: "NextofKinName",
                table: "DeceasedProfiles",
                newName: "NextOfKinName");

            migrationBuilder.RenameColumn(
                name: "DateofDeath",
                table: "DeceasedProfiles",
                newName: "DateOfDeath");

            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "DeceasedProfiles",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "NextofKinContact",
                table: "DeceasedProfiles",
                newName: "RelationshipToDeceased");

            migrationBuilder.AddColumn<string>(
                name: "CHINumber",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinAddress",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinEmail",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinGender",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinPhone",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationOffice",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CHINumber",
                table: "DeceasedProfiles");

            migrationBuilder.DropColumn(
                name: "NextOfKinAddress",
                table: "DeceasedProfiles");

            migrationBuilder.DropColumn(
                name: "NextOfKinEmail",
                table: "DeceasedProfiles");

            migrationBuilder.DropColumn(
                name: "NextOfKinGender",
                table: "DeceasedProfiles");

            migrationBuilder.DropColumn(
                name: "NextOfKinPhone",
                table: "DeceasedProfiles");

            migrationBuilder.DropColumn(
                name: "RegistrationOffice",
                table: "DeceasedProfiles");

            migrationBuilder.RenameColumn(
                name: "NextOfKinName",
                table: "DeceasedProfiles",
                newName: "NextofKinName");

            migrationBuilder.RenameColumn(
                name: "DateOfDeath",
                table: "DeceasedProfiles",
                newName: "DateofDeath");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "DeceasedProfiles",
                newName: "DateofBirth");

            migrationBuilder.RenameColumn(
                name: "RelationshipToDeceased",
                table: "DeceasedProfiles",
                newName: "NextofKinContact");

            migrationBuilder.AddColumn<string>(
                name: "MorgueLocation",
                table: "DeceasedProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
