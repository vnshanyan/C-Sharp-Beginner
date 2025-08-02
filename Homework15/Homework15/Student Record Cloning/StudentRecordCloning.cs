namespace Homework15
{
    public class StudentRecordCloning
    {
        public StudentRecordCloning()
        {
            Student original = new Student()
            {
                Name = "Student1",
                Id = "Student1",
                Grades = new List<Grade>
            {
                new Grade{Subject = "Math", Score = 90},
                new Grade{Subject = "Science", Score = 85},
            }
            };

            Student clonedStudent = (Student)original.Clone();

            // Modify cloned data to verify deep copy
            clonedStudent.Name = "Bob";
            clonedStudent.Grades[0].Score = 50;

            Console.WriteLine("Original Student:");
            Console.WriteLine(original.Name);

            Console.WriteLine("\nCloned Student:");
            Console.WriteLine(clonedStudent.Name);
        }
    }
}
/*
5. StudentRecordCloning
------------------------------------------------
Topic: ICloneable
Model a `Student` class:
- string Name
- string Id
- List<Grade> Grades
Model a `Grade` class:
- string Subject
- double Score
Tasks:
- Implement deep cloning of Student with Grades list.
- Ensure each Grade is also deeply cloned.
*/