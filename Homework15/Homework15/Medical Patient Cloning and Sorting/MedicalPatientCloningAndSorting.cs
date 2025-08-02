namespace Homework15
{
    public class MedicalPatientCloningAndSorting
    {
        public MedicalPatientCloningAndSorting()
        {
            List<Patient> patients = new List<Patient>
            {
                new Patient
                {
                    Name = "Anna",
                    BirthDate = new DateTime(1970, 5, 15),
                    Record = new MedicalRecord { Diagnosis = "Hypertension", LastVisit = new DateTime(2025, 6, 1) }
                },
                new Patient
                {
                    Name = "Ben",
                    BirthDate = new DateTime(1985, 2, 20),
                    Record = new MedicalRecord { Diagnosis = "Asthma", LastVisit = new DateTime(2025, 5, 10) }
                },
                new Patient
                {
                    Name = "Cara",
                    BirthDate = new DateTime(1960, 11, 30),
                    Record = new MedicalRecord { Diagnosis = "Diabetes", LastVisit = new DateTime(2025, 4, 5) }
                }
            };

            // Sort by age (older patients first)
            patients.Sort(); // Ascending birthdate = older first

            Console.WriteLine("Patients Sorted by Age (Older First):");
            foreach (Patient p in patients)
            {
                Console.WriteLine(p.BirthDate);
            }

            // Clone a patient and modify the clone
            Patient cloned = (Patient)patients[0].Clone();
            cloned.Name = "Cloned " + cloned.Name;
            cloned.Record.Diagnosis = "Updated Diagnosis";

            Console.WriteLine("\nOriginal Patient:");
            Console.WriteLine(patients[0].Name);

            Console.WriteLine("\nCloned Patient (Modified):");
            Console.WriteLine(cloned.Name);
        }
    }
}
/*
10. MedicalPatientCloningAndSorting
------------------------------------------------
Topic: IComparable<Patient>, ICloneable
Create a `Patient` class:
- string Name
- DateTime BirthDate
- MedicalRecord Record (class)
Tasks:
- Implement comparison to sort by age (older patients first).
- Implement deep cloning of Patient including MedicalRecord.
*/