﻿namespace XGame.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogador",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        UltimoNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "UK_JOGADOR_EMAIL");
            
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Produtor = c.String(maxLength: 100, unicode: false),
                        Distribuicao = c.String(maxLength: 100, unicode: false),
                        Genero = c.String(maxLength: 100, unicode: false),
                        Site = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Jogador", "UK_JOGADOR_EMAIL");
            DropTable("dbo.Plataforma");
            DropTable("dbo.Jogo");
            DropTable("dbo.Jogador");
        }
    }
}
