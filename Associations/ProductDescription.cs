using System;

namespace Associations
{
    public class ProductDescription
    {
        private string article;
        private string title;
        private DateTime standardTime;

        public string Article
        {
            get => article;
            set => article = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public DateTime StandardTime
        {
            get => standardTime;
            set => standardTime = value;
        }

        public ProductDescription(string article, string title, DateTime standardTime)
        {
            this.article = article;
            this.title = title;
            this.standardTime = standardTime;
        }

        public override string ToString()
        {
            return $"Артикул - {Article}, Наименование - {Title}, Норма рабочего времени на изготовление - {StandardTime}";
        }
    }
}