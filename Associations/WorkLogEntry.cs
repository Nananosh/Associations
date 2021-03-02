using System;

namespace Associations
{
    public class WorkLogEntry
    {
        private DateTime dateTime;
        private String Responsible;
        private TimeSpan timeSpent;
        private String description;

        public DateTime DateTime
        {
            get => dateTime;
            set => dateTime = value;
        }

        public string Responsible1
        {
            get => Responsible;
            set => Responsible = value;
        }

        public TimeSpan TimeSpent
        {
            get => timeSpent;
            set => timeSpent = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public WorkLogEntry(DateTime dateTime, string responsible, TimeSpan timeSpent, string description)
        {
            this.dateTime = dateTime;
            Responsible = responsible;
            this.timeSpent = timeSpent;
            this.description = description;
        }

        public override string ToString()
        {
            return $"Дата и время внесения записи - {DateTime}, Рабочий выполнивший работу - {Responsible}, Время работ - {TimeSpent}, Описание работ - {Description}";
        }
    }
}