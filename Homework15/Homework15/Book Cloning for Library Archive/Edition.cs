namespace Homework15
{
    public class Edition: ICloneable
    {
        public int EditionNumber { get; set; }
        public string Publisher { get; set; }

        public object Clone()
        {
            return new Edition
            {
                EditionNumber = this.EditionNumber,
                Publisher = this.Publisher
            };
        }
    }
}
