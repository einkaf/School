using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] db = new string [0];
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Menu();
                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.A:
                        OneMoreStudent(ref db);
                        break;

                    case ConsoleKey.E:
                        EditStudentInformation(ref db);
                        break;

                    case ConsoleKey.D:
                        DeleteStudent(ref db);
                        break;
                    case ConsoleKey.P:
                        StudentListPrint(db);
                        break;
                    case ConsoleKey.Escape:
                        return;

                    default:
                        Console.WriteLine("Insert correctly please :) ...");
                        Console.ReadKey();
                        break;
                }

            }


        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t* Main Menu *");
            Console.WriteLine(new string('_',50));
            Console.WriteLine();
            Console.WriteLine("\n\tA) Add student");
            Console.WriteLine("\n\tE) Edit student information");
            Console.WriteLine("\n\tD) Delet student information");
            Console.WriteLine("\n\tP) Print student list");
            Console.WriteLine("\n\tEsc) Exit");
        }

        static void OneMoreStudent(ref string[]db)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\n\t* Add Studen Page *");
            Console.WriteLine(new string('_', 50));

            Console.Write("\n\tEnter the FIRST name of the student : ") ;
            string fisrtName = Console.ReadLine();

            Console.Write("\n\tEnter the LAST name of the student : ") ;
            string lastName = Console.ReadLine();            
            
            Console.Write("\n\tEnter the AGE  of the student : ") ;
            string studentAge = Console.ReadLine();

            string newStudent = fisrtName + " " + lastName + " " + studentAge + " 1";

            Array.Resize<string>(ref db, db.Length + 1);

            db[db.Length - 1] = newStudent;
        }

        static void EditStudentInformation(ref string[] db)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\n\t* Edit student information *");
            Console.WriteLine(new string('_', 50));

            Console.Write("\n\tInsert the last name of the student,\n\tthere you want to CHANGE his/her information : ");
            string search = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < db.Length; i++)
            {
                string[] test = db[i].Split(' ');
                if (test[1] == search )
                {
                    Console.Clear();
                    Console.Write("\n\tyour student was found, now ... ");
                    Console.Write("\n\tEnter the new FIRST name of the student : ");
                    string fisrtName = Console.ReadLine();

                    Console.Write("\n\tEnter the new LAST name of the student : ");
                    string lastName = Console.ReadLine();

                    Console.Write("\n\tEnter the new AGE  of the student : ");
                    string studentAge = Console.ReadLine();

                    string newStudent = fisrtName + " " + lastName + " " + studentAge + " 1";

                    db[i] = newStudent;
                    check = true;
                }
            }

            if (check == false)
            {
                Console.Clear();
                Console.WriteLine ("\n\n\n\t\t\tThis student, does not exist!!!!!!");
                Console.ReadKey();
            }
        }

        static void DeleteStudent(ref string[]db)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine("\n\t* Delete student *");
            Console.WriteLine(new string('_', 50));

            Console.Write("\n\tInsert the last name of the student,\n\tthere you want to DELETE his/her information : ");
            string search = Console.ReadLine();

            bool check = false;


            for (int i = 0; i < db.Length; i++)
            {
                string[] test = db[i].Split(' ');
                if (test[1] == search)
                {
                    db[i] = test[0] + " " + test[1] + " " + test[2] + ' ' + "0";
                    check = true;

                }
            }


            if (check == false)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\tThis student, does not exist!!!!!!");
                Console.ReadKey();
            }

        }

        static void StudentListPrint(string[]db)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < db.Length; i++)
            {
                string[] information = db[i].Split(' ');
                if (information[3] == "1" )
                {
                    Console.WriteLine("\n\tfirst name : " + information[0] + "\t\tlast name : " + information[1] + "\t\tstudent age : " + information[2]) ;
                    Console.WriteLine(new string('_', 100));
                }
            }
            Console.ReadKey();
        }
    }
}
