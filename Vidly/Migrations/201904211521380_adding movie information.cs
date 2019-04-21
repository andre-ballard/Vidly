namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmovieinformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Genre = c.String(),
                        ReleaseDate = c.String(),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

            Sql("insert into dbo.Movies (Name, Genre, ReleaseDate, Stock) values('Hangover', 'Comedy', 'Friday, Jan 11, 2010', 3)");
            Sql("insert into dbo.Movies (Name, Genre, ReleaseDate, Stock) values('Die Hard', 'Action', 'Friday, Feb 26, 2010', 1)");
            Sql("insert into dbo.Movies (Name, Genre, ReleaseDate, Stock) values('The Terminator', 'Action', 'Friday, March 1, 2010', 0)");
            Sql("insert into dbo.Movies (Name, Genre, ReleaseDate, Stock) values('Toy Story', 'Family', 'Friday, August 10, 2010', 5)");
            Sql("insert into dbo.Movies (Name, Genre, ReleaseDate, Stock) values('Titanic', 'Comedy', 'Friday, May 5, 2010', 2)");

        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
