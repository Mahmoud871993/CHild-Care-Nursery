namespace DarAlArqamForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentMaterials", "ExamGrade", c => c.Double(nullable: false));
            AddColumn("dbo.StudentMaterials", "ExamDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.StudentMaterials", "Grade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentMaterials", "Grade", c => c.Double(nullable: false));
            DropColumn("dbo.StudentMaterials", "ExamDate");
            DropColumn("dbo.StudentMaterials", "ExamGrade");
        }
    }
}
