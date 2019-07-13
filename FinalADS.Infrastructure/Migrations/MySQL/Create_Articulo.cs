using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(80)]
   public  class Create_Articulo  : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Articulo_Cientifico.sql");
        }

        public override void Down()
        {
        }
    }
}
