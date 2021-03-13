using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Associations
{
    public class Batch
    {
        private int _barcode;
        private DateTime _releaseDate;
        private List<Product> _products;
        

        public int Barcode
        {
            get => _barcode;
            set => _barcode = value;
        }

        public DateTime ReleaseDate
        {
            get => _releaseDate;
            set => _releaseDate = value;
        }

        public List<Product> Products
        {
            get => _products;
            set => _products = value;
        }

        public Batch(int barcode, DateTime releaseDate)
        {
            _barcode = barcode;
            _releaseDate = releaseDate;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public string Show()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Products.Count; i++)
            {
                builder.Append(Products[i]+ Environment.NewLine);
            }
            return builder.ToString();
        }

        public string BatchCategory()
        {
            int countDefective = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].IsDefective == true)
                {
                    countDefective++;
                }
            }
            double countDefectiveProducts = (Products.Count/100)/countDefective;
            bool workTime=false;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].WorkLogEntry.TimeSpent > Products[i].ProductDescription.StandardTime)
                {
                    workTime = false;
                }
                else
                {
                    workTime = true;
                }
            }

            if (workTime == false && countDefective <= 3)
            {
                return "1 категория";
            }
            else
            {
                return "2 категория";
            }
        }


        public override string ToString()
        {
            return $"Штрих код - {Barcode}, Дата выпуска {ReleaseDate},Продукты - \n{Show()}, {BatchCategory()}";
            // $"Серийный номер - {Product.Barcode}, Датя/Время выпуска - {Product.ReleaseDateTime}, Брак - {Product.IsDefective}, " +
            // $"Артикул - {Product.ProductDescription.Article}, Наименование - {Product.ProductDescription.Title}, " +
            // $"Норма рабочего времени на изготовление {Product.ProductDescription.StandardTime.Hour}, " +
            // $"Дата и время внесения записи {Product.WorkLogEntry.DateTime}, Рабочий выполнявший работу {Product.WorkLogEntry.Responsible1}," +
            // $"Время работ {Product.WorkLogEntry.TimeSpent}, Описание работ {Product.WorkLogEntry.Description}";
        }
    }
}