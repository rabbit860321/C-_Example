using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12StudentClass
{
    class Student
    {
        public int StudentID;
        public string Name;
        public int Grade;

        public string Say()
        {
            return "我叫" + Name + "我是" + Grade + "年級的學生";
        }
        public void Upgrade()
        {
            Grade++;
        }
        public string Talk(Student s)
        {
            return Grade + "年級的" + Name + "對" + s.Grade + "年級的" + s.Name + "說哈囉";
        }
    }
}
