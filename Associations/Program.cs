using System;
using System.Collections.Generic;

namespace Associations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Batch> batch = new List<Batch>();//заказчики
            List<Product> products = new List<Product>();//продукты
            List<ProductDescription> productDescription = new List<ProductDescription>();// номенклатура
            List<WorkLogEntry> workLogEntries = new List<WorkLogEntry>();//записи в журнал
            //products[0].AddWorkLongEntry(new WorkLogEntry(new DateTime(1, 2, 4), "Дмитрий Медведев",
            //    new TimeSpan(0, 4, 0, 0), "Работы была выполнена без трудностей"));
            productDescription.Add(new ProductDescription("54321", "Машинка", new DateTime(1, 1, 1, 5, 0, 0, 0)));
            workLogEntries.Add(new WorkLogEntry(new DateTime(1, 2, 4), "Дмитрий Медведев", new DateTime(1,1,1,6,0,0,0),"Работы была выполнена без трудностей"));
            batch.Add(new Batch(12345, new DateTime(1, 2, 3)));
            //products[0].AddWorkLongEntry(new WorkLogEntry(new DateTime(1, 2, 4), "Дмитрий Медведев",
            //   new TimeSpan(0, 4, 0, 0), "Работы была выполнена без трудностей"));
            batch[0].AddProduct(new Product(1, new DateTime(1, 2, 3), false,productDescription[0],workLogEntries[0]));
            batch[0].AddProduct(new Product(2, new DateTime(1, 2, 3), false,productDescription[0],workLogEntries[0]));
            batch[0].AddProduct(new Product(3, new DateTime(1, 2, 3), true,productDescription[0],workLogEntries[0])); 
            batch[0].AddProduct(new Product(4, new DateTime(1, 2, 3), false,productDescription[0],workLogEntries[0]));
            Console.WriteLine(batch[0].ToString());
        }
    }
}