using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

class OOB_2
{
    public class Student
    {
        public string name;
        public float gpa;

        public string Name { get => name; set => name = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        public Student()
        {
            name = "None";
            gpa = 0;
        }
        public Student(string name_, float gpa_)
        {
            name = name_;
            gpa = gpa_;
        }
        public Student(Student st)
        {
            this.name = st.name;
            this.gpa = st.gpa;
        }
        public string ShowInfo()
        {
            return $"Student: {name}, gpa: {gpa}";
        }
    }
    static void SortArray(Student[] students)
    {
        Array.Sort(students, (st1, st2) => st2.gpa.CompareTo(st1.gpa));
    }
    static void Main(string[] args)
    {
        Student[] students = new Student[10]
        {
        new Student("Nam", 8.2f),
        new Student("Nam", 8.2f),
        new Student("Hoa", 8.5f),
        new Student("Binh", 9),
        new Student("Lan", 6.8f),
        new Student("Tuan", 8.3f),
        new Student("Dat", 8.5f),
        new Student("Bao", 8.6f),
        new Student("Nghiem", 8),
        new Student("Tran", 8.7f),
        };
        SortArray(students);
        Console.WriteLine("Danh sach sinh vien co so GPA giam dan");
        for(int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Id: {i+1}, Name: {students[i].Name}, GPA: {students[i].Gpa}");
        };
        Console.ReadKey();
    }
}

        
