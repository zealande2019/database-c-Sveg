using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppDatabase
{
    public class Student
    {
        public Student(int studentid, string name, string mobilnr)
        {
            studentid = Studentid;
            name = Name;
            mobilnr = Mobilnr;
        }

        public int Studentid { get; set; }

        public string Name { get; set; }

        public string Mobilnr { get; set; }

        
    }
}