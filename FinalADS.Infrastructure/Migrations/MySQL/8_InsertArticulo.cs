using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(124)]
    public class InsertArticulo : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("8_InsertArticulo.sql");
        }

        public override void Down()
        {
        }
    }
}
