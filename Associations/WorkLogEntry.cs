using System;

namespace Associations
{
    public class WorkLogEntry
    {
        private DateTime _dateTime;
        private String _Responsible;
        private TimeSpan _timeSpent;
        private String _description;

        public DateTime DateTime
        {
            get => _dateTime;
            set => _dateTime = value;
        }

        public string Responsible1
        {
            get => _Responsible;
            set => _Responsible = value;
        }

        public TimeSpan TimeSpent
        {
            get => _timeSpent;
            set => _timeSpent = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public WorkLogEntry(DateTime dateTime, string responsible, TimeSpan timeSpent, string description)
        {
            this._dateTime = dateTime;
            _Responsible = responsible;
            this._timeSpent = timeSpent;
            this._description = description;
        }

        public override string ToString()
        {
            return $"Дата и время внесения записи - {DateTime}, Рабочий выполнивший работу - {_Responsible}, Время работ - {TimeSpent}, Описание работ - {Description}";
        }
    }
}