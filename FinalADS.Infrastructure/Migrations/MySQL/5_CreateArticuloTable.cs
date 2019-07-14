using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(122)]
    public class AutorTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("5_CreateArticuloTable.sql");
        }

        public override void Down()
        {
        }
    }
}
