using System;

namespace Bästkusten
{

    class Program
    {
       
        static void Main(string[] args)
        {
            string password;
            
            Console.WriteLine("Hej och välkommen!");
            Console.WriteLine("Vänligen ange lösenord.");
            password = Console.ReadLine().ToLower();

            if (password == "bästkusten")
            {
                Console.WriteLine("Snyggt");

                Student David = new Student("David", 32, 1.83, "Norrtälje", "Göteborg", "Gracie Jiu-Jitsu", "Tacos", "Blå", 1, "Problemlösning");
                Student Johan = new Student("Johan", 34, 1.94, "Mariefred", "Mariefred", "Gaming", "Tacos", "Blå", 2, "Trygg framtid");
                Student Oscar = new Student("Oscar", 26, 1.85, "Stockholm", "Stockholm", "Fotboll", "Lasagne", "Blå", 1, "Jobb");
                Student Sanjin = new Student("Sanjin", 30, 1.79, "Norrköping", "Mostar", "Fotboll", "Pizza", "Blå", 2, "Jobb");
                Student Jeremy = new Student("Jeremy", 19, 1.81, "Djurö", "Köln", "Gaming", "Älggryta", "Teal", 1, "Jobb");
                Student Cecilia = new Student("Cecilia", 29, 1.63, "Norrköping", "Norrköping", "The Sims", "Risotto", "Gul", 1, "Kreativitet");
                Student Elin = new Student("Elin", 31, 1.70, "Knivsta", "Karlskoga", "Hästar", "Sushi", "Röd", 2, "Personlig utveckling");
                Student Ivo = new Student("Ivo", 42, 1.74, "Uppsala", "Split", "Fotografi", "Scampi", "Svart", 1, "Kreativitet");
                Student Mostafa = new Student("Mostafa", 33, 1.74, "Stockholm", "Stockholm", "Träning""Oxfilé", "Svart", 4, "Tycker om att koda och lösa problem");
                    
            }

            else
            {
                Console.WriteLine("Fel lösenord. Försök igen.");
                return;
            }
                    
            
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
