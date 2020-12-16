using System;
using System.Collections.Generic;

namespace Bästkusten
{

    class Program
    {
        //method for printing menu options
        public static void PrintMenu()
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lista alla medlemmar i gruppen.");
            Console.WriteLine("2. Lära känna en medlem i gruppen.");
            Console.WriteLine("3. Ta bort en medlem i gruppen.");
            Console.WriteLine("4. Avsluta programmet");
        }
        //method for adding objects to list and return list
        public static List<Student> GetStudentsList()
        {
            List<Student> listOfStudents = new List<Student>();

            Student David = new Student("David", 32, 1.83, "Norrtälje", "Göteborg", "Gracie Jiu-Jitsu", "Tacos", "Blå", 1, "Problemlösning");
            Student Johan = new Student("Johan", 34, 1.94, "Mariefred", "Mariefred", "Gaming", "Tacos", "Blå", 2, "Trygg framtid");
            Student Oscar = new Student("Oscar", 26, 1.85, "Stockholm", "Stockholm", "Fotboll", "Lasagne", "Blå", 1, "Jobb");
            Student Sanjin = new Student("Sanjin", 30, 1.79, "Norrköping", "Mostar", "Fotboll", "Pizza", "Blå", 2, "Jobb");
            Student Jeremy = new Student("Jeremy", 19, 1.81, "Djurö", "Köln", "Gaming", "Älggryta", "Teal", 1, "Jobb");
            Student Cecilia = new Student("Cecilia", 29, 1.63, "Norrköping", "Norrköping", "The Sims", "Risotto", "Gul", 1, "Kreativitet");
            Student Elin = new Student("Elin", 31, 1.70, "Knivsta", "Karlskoga", "Hästar", "Sushi", "Röd", 2, "Personlig utveckling");
            Student Ivo = new Student("Ivo", 42, 1.74, "Uppsala", "Split", "Fotografi", "Scampi", "Svart", 1, "Kreativitet");
            Student Mostafa = new Student("Mostafa", 33, 1.74, "Stockholm", "Stockholm", "Träning", "Oxfilé", "Svart", 4, "Tycker om att koda och lösa problem");

            listOfStudents.Add(David);
            listOfStudents.Add(Johan);
            listOfStudents.Add(Oscar);
            listOfStudents.Add(Sanjin);
            listOfStudents.Add(Jeremy);
            listOfStudents.Add(Cecilia);
            listOfStudents.Add(Elin);
            listOfStudents.Add(Ivo);
            listOfStudents.Add(Mostafa);

            return listOfStudents;
        }

        static void Main(string[] args)
        {
            //declaring variables for user input
            string password;
            string choice = "";
            int listNr;

            Console.WriteLine("Hej och välkommen!");
            do
            {
                Console.WriteLine("Vänligen ange lösenord.");
                password = Console.ReadLine().ToLower();

                if (password == "bästkusten")
                {
                    Console.WriteLine("Välkommen!");
                    List<Student> listOfStudents = GetStudentsList();

                    while (choice != "4")
                    {
                        PrintMenu();
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                listNr = 1;
                                foreach (var Student in listOfStudents)
                                {
                                    Console.WriteLine(listNr + ". " + Student.Name);
                                    listNr++;
                                }
                                break;

                            case "2":
                                listNr = 1;
                                Console.WriteLine("Skriv numret på den du önskar veta mer om.");
                                Console.WriteLine("");
                                foreach (var Student in listOfStudents)
                                {
                                    Console.WriteLine(listNr + ". " + Student.Name);
                                    listNr++;
                                }

                                int i = Convert.ToInt32(Console.ReadLine());
                                Student s = listOfStudents[i - 1];
                                s.PrintStudent();
                                break;

                            case "3":
                                listNr = 1;
                                Console.WriteLine("Skriv numret på den du önskar ta bort.");
                                Console.WriteLine("");
                                foreach (var Student in listOfStudents)
                                {
                                    Console.WriteLine(listNr + ". " + Student.Name);
                                    listNr++;
                                }

                                i = Convert.ToInt32(Console.ReadLine());
                                listOfStudents.RemoveAt(i - 1);
                                Console.WriteLine("Plats " + i + " är borttagen.");
                                break;

                            default:
                                Console.WriteLine("Ogiltigt val, försök igen");
                                Console.WriteLine("");
                                break;
                        }

                    }
                }
                //repeat until correct password
                else
                {
                    Console.WriteLine("Fel lösenord. Försök igen.");
                }
            } while (password != "bästkusten");

            Console.Clear();
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
        //method for printing all Student information
        public void PrintStudent()
        {
            Console.WriteLine($"{name} är {age} år gammal och {height} m. lång, bor i {hometown} och är född i {birthtown}.");
            Console.WriteLine($"{name}s hobby är {hobby} och {name} gillar även {favFood} och färgen {favColor}.");
            Console.WriteLine($"{name} har {nrOfSiblings} syskon och {motivation} är hens främsta motivation till att lära sig programmering.");
        }

        //properties
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
                return hometown;
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
                return favFood;
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
