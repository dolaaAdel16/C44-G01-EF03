using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF03.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create Or Alter View DepartmentMangersView
                                    as  
                                        Select E.Id as EmpId , E.Name , D.Id as DeptId , D.DeptName
                                        From Employees E , Departments D 
                                        Where E.Id = D.ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View DepartmentMangersView");
        }
    }
}
