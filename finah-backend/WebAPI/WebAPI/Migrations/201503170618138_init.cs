namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Antwoord",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Vraag_Id = c.Int(nullable: false),
                    Rapport_Id = c.Int(nullable: false),
                    AntwoordInt = c.Int(nullable: false),
                    AntwoordExtra = c.Int(nullable: false),
                    Verzorger = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vraag", t => t.Vraag_Id)
                .ForeignKey("dbo.Rapport", t => t.Rapport_Id)
                .Index(t => t.Vraag_Id)
                .Index(t => t.Rapport_Id);

            CreateTable(
                "dbo.Rapport",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NaamVerzorger = c.String(nullable: false),
                    NaamPatient = c.String(nullable: false),
                    Date = c.DateTime(nullable: false),
                    Vragenlijst_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vragenlijst", t => t.Vragenlijst_Id)
                .Index(t => t.Vragenlijst_Id);

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    RoleId = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                    IdentityRole_Id = c.String(maxLength: 128),
                    IdentityUser_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.IdentityUser_Id);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Email = c.String(),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                    IdentityUser_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    LoginProvider = c.String(),
                    ProviderKey = c.String(),
                    IdentityUser_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);

            CreateTable(
                "dbo.Vraag",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Beschrijving = c.String(nullable: false, maxLength: 450),
                    Vragenlijst_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vragenlijst", t => t.Vragenlijst_Id)
                .Index(t => t.Vragenlijst_Id);

            CreateTable(
                "dbo.Vragenlijst",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Beschrijving = c.String(nullable: false, maxLength: 450),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "IdentityRole_Id", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "IdentityRole_Id" });
            DropTable("dbo.Antwoord");
            DropTable("dbo.Vraag");
            DropTable("dbo.Rapport");
            DropTable("dbo.Vragenlijst");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
