using System;

namespace Associations
{
    public class ProductDescription
    {
        private string _article;
        private string _title;
        private DateTime _standardTime;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public DateTime StandardTime
        {
            get => _standardTime;
            set => _standardTime = value;
        }

        public ProductDescription(string article, string title, DateTime standardTime)
        {
            this._article = article;
            this._title = title;
            this._standardTime = standardTime;
        }

        public override string ToString()
        {
            return $"Артикул - {Article}, Наименование - {Title}, Норма рабочего времени на изготовление - {StandardTime}";
        }
    }
}