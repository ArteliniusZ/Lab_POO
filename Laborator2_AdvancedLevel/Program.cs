using System;
using System.Collections.Generic;

namespace POOlab1_task2_
{
    class University
    {
        private string name { get; set; }
        private int foundationYear { get; set; }

        private List<Student> studlist = new List<Student>();
       



        public University(string name1, int year, List<Student> studlist)
        {
            this.name = name1;
            this.foundationYear = year;
            this.studlist = studlist;
            
        }



        //public string getName()
        //{
        //    return name;
        //}
        //public int getYear()
        //{
        //    return foundationYear;
        //}

        public List<Student> getStudlist()
        {
            return studlist;
        }

        public void setStudlist(List<Student> studlist)
        {
            this.studlist = studlist;
        }
    



        public string getName()
        {
            return name;
        }

        public int getYear()
        {
            return foundationYear;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setYear(int foundationYear)
        {
            this.foundationYear = foundationYear;
        }



    }

    class Student
    {
        public string name1 { get; set; }
        public int age { get; set; }
        public double mark { get; set; }

        public Student(string namestud, int agestud, double markstud)
        {
            this.name1 = namestud;
            this.age = agestud;
            this.mark = markstud;
        }

        public string getName1()
        {
            return this.name1;
        }

        public int getAge()
        {
            return this.age;
        }

        public double getMark()
        {
            return this.mark;
        }

        public void setName1(string name1)
        {
            this.name1 = name1;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
        public void setMark(double mark)
        {
            this.mark = mark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Student stud1 = new Student("Mark", 20, 6.33);
            Student stud2 = new Student("Edward", 21, 5.57);
            Student stud0 = new Student("Michael", 19, 7.23);
            List<Student> studlist = new List<Student>();
            studlist.Add(stud1);
            studlist.Add(stud2);
            studlist.Add(stud0);
            University uni = new University("UTM", 1964, studlist);
            Console.WriteLine("First university");
            Console.WriteLine("University name: " + uni.getName());
            Console.WriteLine("Year of foundation: " + uni.getYear());

            foreach (var stud in studlist)
            {
                Console.WriteLine("--");
                Console.WriteLine("Student's name: " + stud.getName1());
                Console.WriteLine("Student's age: " + stud.getAge());
                Console.WriteLine("Student's mark: " + stud.getMark());
            }
            Console.WriteLine("--");
            double average = (stud1.getMark() + stud2.getMark() + stud0.getMark()) / 3;
            Console.WriteLine("The avarage mark for UTM students is: {0:F2}", average);




            Console.WriteLine("--------------------------------------------");



            
            Student stud3 = new Student("John", 23, 9.29);
            Student stud4 = new Student("Lucy", 24, 8.54);
            Student stud5 = new Student("Mary", 18, 5.18);
            List<Student> studlist1 = new List<Student>();
            studlist1.Add(stud3);
            studlist1.Add(stud4);
            studlist1.Add(stud5);
            Console.WriteLine("Second university");
            University uni1 = new University("USM", 1946, studlist1);
            Console.WriteLine("University name: " + uni1.getName());
            Console.WriteLine("Year of foundation: " + uni1.getYear());

            foreach (var item in studlist1)
            {
                Console.WriteLine("--");
                Console.WriteLine("Student's name: " + item.getName1());
                Console.WriteLine("Student's age: " + item.getAge());
                Console.WriteLine("Student's mark: " + item.getMark());

            }
            Console.WriteLine("--");
            double average1 = (stud3.mark + stud4.mark + stud5.mark) / 3;
            Console.WriteLine("The avarage mark for USM students is: {0:F2}", average1);

            Console.WriteLine("--------------------------------------------");


            
            Student stud6 = new Student("Michelle", 22, 8.98);
            Student stud7 = new Student("Jonathan", 25, 7.64);
            Student stud8 = new Student("Peter", 28, 6.78);
            List<Student> studlist2 = new List<Student>();
            studlist2.Add(stud6);
            studlist2.Add(stud7);
            studlist2.Add(stud8);
            Console.WriteLine("Thrid university");
            University uni2 = new University("ULIM", 1992, studlist2);
            Console.WriteLine("University name: " + uni2.getName());
            Console.WriteLine("Year of foundation: " + uni2.getYear());

            foreach (var item1 in studlist2)
            {
                Console.WriteLine("--");
                Console.WriteLine("Student's name: " + item1.getName1());
                Console.WriteLine("Student's age: " + item1.getAge());
                Console.WriteLine("Student's mark: " + item1.getMark());

            }
            Console.WriteLine("--");
            double average2 = (stud6.mark + stud7.mark + stud8.mark) / 3;
            Console.WriteLine("The avarage mark ULIM students is: {0:F2}", average2);

        }
    }
}

