using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Globant.Java2Net.Demos.App.Sql;
using Globant.Java2Net.Demos.App.EF;

namespace Globant.Java2Net.Demos.App
{
    class Program
    {
        private static readonly string _dataSource = "localhost";
        private static readonly string _userId = "sa";
        private static readonly string _password = "824679135";
        static void Main(string[] args)
        {
            StringBuilder menu = new StringBuilder();

            menu.AppendLine("Choose an option");
            menu.AppendLine("1. Ado Connect Server Demo");
            menu.AppendLine("2. Ado Create Database Demo");
            menu.AppendLine("3. EF Crud Demo");
            menu.AppendLine("4. Index Demo");
            menu.AppendLine("5. Exit");
            bool cont = true;
            do
            {
                Console.Clear();
                Console.WriteLine(menu.ToString());
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        ClassicAdoDemo.ServerConnect(_dataSource, _userId, _password);
                        break;
                    case "2":
                        ClassicAdoDemo.CreateDBDemo(_dataSource, _userId, _password);
                        break;
                    case "3":
                        EFCrudDemo.EFCrud(_dataSource, _userId, _password);
                        break;
                    case "4":
                        ClassicAdoDemo.Index(_dataSource, _userId, _password);
                        break;
                    case "5":
                        cont = false;
                        break;
                }

            } while (cont);
        }
    }
}
