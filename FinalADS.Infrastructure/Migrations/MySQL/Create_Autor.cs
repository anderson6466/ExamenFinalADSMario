using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(79)]
   public  class Create_Autor : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Autor.sql");
        }

        public override void Down()
        {
        }


    }
}
