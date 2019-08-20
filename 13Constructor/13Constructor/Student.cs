using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Constructor
{
    class Student
    {
        public int ID;
        public string name;
        public int grade;

        public Student(int id,string name,int grade)
        {
            this.ID = id;
            this.name = name;
            this.grade = grade;
        }
        public Student(string name,int grade)  //overloaded
        {
            this.name = name;
            this.grade = grade;
        }
        public string say()
        {
            return "我叫" + name + "我是" + grade + "年級的學生";
        }
        public string talk(Student s)
        {
            return grade + "年級的" + name + "對" + s.grade + "年級的" + s.name + "說哈囉";
        }
        public void upgrade()
        {
            grade++;
        }
    }
}
