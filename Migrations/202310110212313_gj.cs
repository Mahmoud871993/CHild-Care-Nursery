namespace DarAlArqamForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "EmployeeSalary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Payments", "TeacherSalary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Payments", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Payments", "TeacherSalary");
            DropColumn("dbo.Payments", "EmployeeSalary");
        }
    }
}
