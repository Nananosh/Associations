using System;
using System.Collections.Generic;
using System.Text;

namespace Associations
{
    public class Product
    {
        private int _barcode;
        private DateTime _releaseDateTime;
        private bool _isDefective;
        private ProductDescription _productDescription;
        private List<WorkLogEntry> _workLogEntries;

        public int Barcode
        {
            get => _barcode;
            set => _barcode = value;
        }

        public DateTime ReleaseDateTime
        {
            get => _releaseDateTime;
            set => _releaseDateTime = value;
        }

        public bool IsDefective
        {
            get => _isDefective;
            set => _isDefective = value;
        }

        public ProductDescription ProductDescription
        {
            get => _productDescription;
            set => _productDescription = value;
        }

        public List<WorkLogEntry> WorkLogEntries
        {
            get => _workLogEntries;
            set => _workLogEntries = value;
        }

        public Product(int barcode, DateTime releaseDateTime, bool isDefective, ProductDescription productDescription)
        {
            this._barcode = barcode;
            this._releaseDateTime = releaseDateTime;
            this._isDefective = isDefective;
            this._productDescription = productDescription;
            this._workLogEntries = new List<WorkLogEntry>();
        }
        public void AddWorkLongEntry(WorkLogEntry workLogEntry)
        {
            WorkLogEntries.Add(workLogEntry);
        }
        public string ShowTasks()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < WorkLogEntries.Count; i++)
            {
                builder.Append(WorkLogEntries[i]+ Environment.NewLine);
            }
            return builder.ToString();
        }

        public override string ToString()
        {
            return $"Серийный номер - {Barcode}, Датя/Время выпуска - {ReleaseDateTime}, Брак - {IsDefective}, " +
                   $"Артикул - {ProductDescription.Article}, Наименование - {ProductDescription.Title}, " +
                   $"Норма рабочего времени на изготовление {ProductDescription.StandardTime}," +
                   $"Журнал - {ShowTasks()}";
            //$"Дата и время внесения записи {WorkLogEntry.DateTime}, Рабочий выполнявший работу {WorkLogEntry.Responsible1}," +
            //$"Время работ {WorkLogEntry.TimeSpent}, Описание работ {WorkLogEntry.Description}";
        }
    }
}