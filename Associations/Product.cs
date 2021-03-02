using System;

namespace Associations
{
    public class Product
    {
        private int barcode;
        private DateTime releaseDateTime;
        private bool isDefective;

        public int Barcode
        {
            get => barcode;
            set => barcode = value;
        }

        public DateTime ReleaseDateTime
        {
            get => releaseDateTime;
            set => releaseDateTime = value;
        }

        public bool IsDefective
        {
            get => isDefective;
            set => isDefective = value;
        }

        public Product(int barcode, DateTime releaseDateTime, bool isDefective)
        {
            this.barcode = barcode;
            this.releaseDateTime = releaseDateTime;
            this.isDefective = isDefective;
        }

        public override string ToString()
        {
            return $"Серийный номер - {Barcode}, Датя/Время выпуска - {ReleaseDateTime}, Брак {IsDefective}";
        }
    }
}