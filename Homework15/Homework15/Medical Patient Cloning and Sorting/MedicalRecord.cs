namespace Homework15
{
    public class MedicalRecord: ICloneable
    {
        public string Diagnosis { get; set; }
        public DateTime LastVisit { get; set; }

        public object Clone()
        {
            return new MedicalRecord
            {
                Diagnosis = Diagnosis,
                LastVisit = LastVisit
            };
        }
    }
}