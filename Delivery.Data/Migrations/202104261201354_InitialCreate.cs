namespace Delivery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarDeliveryStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.Int(nullable: false),
                        DepartmentId = c.Int(),
                        DriverId = c.Int(nullable: false),
                        PostManagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .ForeignKey("dbo.PostManagers", t => t.PostManagerId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DriverId)
                .Index(t => t.PostManagerId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Int(nullable: false),
                        Costs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Int(nullable: false),
                        ClientWhoSendId = c.Int(nullable: false),
                        ClientWhoGetId = c.Int(nullable: false),
                        PostManagerId = c.Int(nullable: false),
                        DriverId = c.Int(),
                        DepartmentFromId = c.Int(nullable: false),
                        DepartmentToId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientWhoGetId)
                .ForeignKey("dbo.Clients", t => t.ClientWhoSendId)
                .ForeignKey("dbo.Departments", t => t.DepartmentFromId)
                .ForeignKey("dbo.Departments", t => t.DepartmentToId)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .ForeignKey("dbo.PostManagers", t => t.PostManagerId)
                .Index(t => t.ClientWhoSendId)
                .Index(t => t.ClientWhoGetId)
                .Index(t => t.PostManagerId)
                .Index(t => t.DriverId)
                .Index(t => t.DepartmentFromId)
                .Index(t => t.DepartmentToId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        CountBadParcels = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarryingCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.CarDeliveryStatus", "PostManagerId", "dbo.PostManagers");
            DropForeignKey("dbo.CarDeliveryStatus", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.CarDeliveryStatus", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Parcels", "PostManagerId", "dbo.PostManagers");
            DropForeignKey("dbo.Parcels", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Drivers", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Parcels", "DepartmentToId", "dbo.Departments");
            DropForeignKey("dbo.Parcels", "DepartmentFromId", "dbo.Departments");
            DropForeignKey("dbo.Parcels", "ClientWhoSendId", "dbo.Clients");
            DropForeignKey("dbo.Parcels", "ClientWhoGetId", "dbo.Clients");
            DropForeignKey("dbo.Departments", "CityId", "dbo.Cities");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Drivers", new[] { "CarId" });
            DropIndex("dbo.Parcels", new[] { "DepartmentToId" });
            DropIndex("dbo.Parcels", new[] { "DepartmentFromId" });
            DropIndex("dbo.Parcels", new[] { "DriverId" });
            DropIndex("dbo.Parcels", new[] { "PostManagerId" });
            DropIndex("dbo.Parcels", new[] { "ClientWhoGetId" });
            DropIndex("dbo.Parcels", new[] { "ClientWhoSendId" });
            DropIndex("dbo.Departments", new[] { "CityId" });
            DropIndex("dbo.CarDeliveryStatus", new[] { "PostManagerId" });
            DropIndex("dbo.CarDeliveryStatus", new[] { "DriverId" });
            DropIndex("dbo.CarDeliveryStatus", new[] { "DepartmentId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PostManagers");
            DropTable("dbo.Cars");
            DropTable("dbo.Drivers");
            DropTable("dbo.Clients");
            DropTable("dbo.Parcels");
            DropTable("dbo.Cities");
            DropTable("dbo.Departments");
            DropTable("dbo.CarDeliveryStatus");
        }
    }
}
