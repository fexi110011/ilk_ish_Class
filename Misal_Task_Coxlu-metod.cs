using System.Text.RegularExpressions;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("Fexreddin_Ehmedov",109,1000);
            Student student02 = new Student("Kenen_Mehdiyev", 109, 1200);
            Student student03 = new Student("Abbas_Abbasov", 101, 1300);


        }
    }
    class Student
    {
        string FullName;
        int GroupNo;
        int AvgPoint;
        public Student(string fullname,int groupNo,int avgPoint)
        {
            FullName = fullname;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }
       
    }
    class Group
    {
        int No;
        string[] Students;
        int StudentLimit;
        public Group(int no, int studentlimit)
        {
            No = no;
            StudentLimit = studentlimit;
        }
        public bool AddStudent(Student student) {
            int[] new_Student;
            for (int i = 0; Students.Length > 0; i++)
            {

            }
            return true;
        }
    }
}
