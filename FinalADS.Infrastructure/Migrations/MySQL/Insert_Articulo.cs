using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(83)]
   public    class Insert_Articulo : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("InsertArticulo_Cientifico.sql");
        }

        public override void Down()
        {
        }

    }
}
