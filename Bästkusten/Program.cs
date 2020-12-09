using System;

namespace Bästkusten
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //class with private fields
    class Student
    {
        private string name;
        private int age;
        private double height;
        private string hometown;
        private string birthtown;
        private string hobby;
        private string favFood;
        private string favColor;
        private int nrOfSiblings;
        private string motivation;

        //standard constructor;
        public Student()
        {

        }

        //constructor with public fields
        public Student(string name, int age, double height, string hometown, string birthtown, string hobby, string favFood, string favColor, int nrOfSiblings, string motivation)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.hometown = hometown;
            this.birthtown = birthtown;
            this.hobby = hobby;
            this.favFood = favFood;
            this.favColor = favColor;
            this.nrOfSiblings = nrOfSiblings;
            this.motivation = motivation;
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public string Hometown
        {
            get
            {
                return Hometown;
            }
            set
            {
                hometown = value;
            }
        }

        public string Birthtown
        {
            get
            {
                return birthtown;
            }
            set
            {
                birthtown = value;
            }

        }

        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }
        }
       public string FavFood
        {
            get
            {
                return FavFood;
            }
            set
            {
                favFood = value;
            }
        }
        public string FavColor
        {
            get
            {
                return favColor;
            }
            set
            {
                favColor = value;
            }
        }

        public int NrOfSiblings
        {
            get
            {
                return nrOfSiblings;
            }
            set
            {
                nrOfSiblings = value;
            }
        }

        public string Motivation
        {
            get
            {
                return motivation;
            }
            set
            {
                motivation = value;
            }
        }

    }
}
