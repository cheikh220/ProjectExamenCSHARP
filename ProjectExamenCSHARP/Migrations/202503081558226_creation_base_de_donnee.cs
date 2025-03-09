namespace ProjectExamenCSHARP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creation_base_de_donnee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        HeureDebut = c.DateTime(nullable: false),
                        HeureFin = c.DateTime(nullable: false),
                        SalleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Salles", t => t.SalleId, cascadeDelete: true)
                .Index(t => t.SalleId);
            
            CreateTable(
                "dbo.Salles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emargements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Statut = c.String(),
                        ProfesseurId = c.Int(nullable: false),
                        CoursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cours", t => t.CoursId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ProfesseurId, cascadeDelete: true)
                .Index(t => t.ProfesseurId)
                .Index(t => t.CoursId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        DestinataireId = c.Int(nullable: false),
                        DateEnvoi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.DestinataireId, cascadeDelete: true)
                .Index(t => t.DestinataireId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "DestinataireId", "dbo.Users");
            DropForeignKey("dbo.Emargements", "ProfesseurId", "dbo.Users");
            DropForeignKey("dbo.Emargements", "CoursId", "dbo.Cours");
            DropForeignKey("dbo.Cours", "SalleId", "dbo.Salles");
            DropIndex("dbo.Notifications", new[] { "DestinataireId" });
            DropIndex("dbo.Emargements", new[] { "CoursId" });
            DropIndex("dbo.Emargements", new[] { "ProfesseurId" });
            DropIndex("dbo.Cours", new[] { "SalleId" });
            DropTable("dbo.Notifications");
            DropTable("dbo.Users");
            DropTable("dbo.Emargements");
            DropTable("dbo.Salles");
            DropTable("dbo.Cours");
        }
    }
}
