using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(81)]
  public    class Insert_Autor : Migration




    {
        public override void Up()
        {
            Execute.EmbeddedScript("InsertAutor.sql");
        }

        public override void Down()
        {
        }


    }
}
