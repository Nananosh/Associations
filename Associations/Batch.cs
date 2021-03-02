using System;

namespace Associations
{
    public class Batch
    {
        private int barcode;
        private DateTime releaseDate;

        public int Barcode
        {
            get => barcode;
            set => barcode = value;
        }

        public DateTime ReleaseDate
        {
            get => releaseDate;
            set => releaseDate = value;
        }

        public Batch(int barcode, DateTime releaseDate)
        {
            this.Barcode = barcode;
            this.ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Штрих код - {Barcode}, Дата выпуска {ReleaseDate}";
        }
    }
}