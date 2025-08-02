namespace Homework15
{
    public class Student: ICloneable
    {
        public string? Name { get; set; }
        public string? Id { get; set; }
        public List<Grade>? Grades { get; set; }

        public object Clone()
        {
            var clonedGrades = new List<Grade>();
            foreach (var grade in Grades)
            {
                clonedGrades.Add((Grade)grade.Clone());
            }
            return new Student
            {
                Name = this.Name,
                Id = this.Id,
                Grades = clonedGrades,
            };
        }
    }
}
