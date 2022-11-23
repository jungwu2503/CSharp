using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableEx
{
    [Serializable]
    public class Student
    {
        String name;
        int kor, eng, math, sum;
        bool isScholar;

        public Student(String name, int kor, int eng, int math)
        {
            this.name = name;
            this.kor = kor;
            this.eng = eng;
            this.math = math;
            this.sum = kor + eng + math;
            isScholar = sum >= 100 ? true : false;
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public int Kor
        {
            get
            {
                return kor;
            }
        }

        public int Eng
        {
            get
            {
                return eng;
            }
        }

        public int Math
        {
            get
            {
                return math;
            }
        }

        public int Sum
        {
            get
            {
                return sum;
            }
        }

        public bool IsScholar
        {
            get
            {
                return isScholar;
            }
        }

    }
}
