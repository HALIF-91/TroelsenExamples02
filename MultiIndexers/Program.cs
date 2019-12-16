using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = MultiIndexerWithDataTable();
            PeopleCollection people = new PeopleCollection(table);
            Console.WriteLine();

            // если незнаешь соответствующий индекс столбца, но знаешь название
            Console.WriteLine("First Name: {0}", people[0, "FirstName"]);
            Console.WriteLine("Last Name: {0}", people[0, "LastName"]);
            Console.WriteLine("Age: {0}", people[0, "Age"]);
            Console.ReadLine();
        }
        static DataTable MultiIndexerWithDataTable()
        {
            // создать простой объект DataTable с тремя столбцами
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("FirstName"));
            table.Columns.Add(new DataColumn("LastName"));
            table.Columns.Add(new DataColumn("Age"));

            // добавить строку к таблице
            table.Rows.Add("Mel", "Appleby", 60);

            // использовать многомерный индексатор для вывода деталей первой строки
            Console.WriteLine("First Name: {0}", table.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", table.Rows[0][1]);
            Console.WriteLine("Age: {0}", table.Rows[0][2]);

            return table;
        }
    }
}
