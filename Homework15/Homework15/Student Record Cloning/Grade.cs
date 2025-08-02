namespace Homework15
{
    public class Grade: ICloneable
    {
        public string Subject { get; set; }
        public double Score { get; set; }

        public object Clone()
        {
            return new Grade
            {
                Score = this.Score,
                Subject = this.Subject,
            };
        }
    }
}
