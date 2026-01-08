using System;
using System.Collections.Generic;
using System.Linq;

namespace GIK299_L4_Labbgrupp123
{
    internal class Program
    {
        internal static List<Person> PersonList = new List<Person>();

        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Add new person");
                Console.WriteLine("2. Print list of added persons");
                Console.WriteLine("3. Terminate Program\n");
                string _ = Console.ReadLine();
                if (int.TryParse(_, out int Choice))
                {
                    switch (Choice)
                    {
                        case 1:
                            Console.Clear();
                            AddPerson();
                            break;

                        case 2:
                            Console.Clear();
                            ListPerson();
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invaild input");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input correct answer is numbers (1-3)");
                }
            }
        }

        static void AddPerson()
        {
            Names InputName = new Names(); 
            Gender InputGender = Gender.Other;
            Hair InputHair = new Hair();
            string InputEyeColor = "Blue";
            DateTime InputDate = DateTime.Now;

            while (true)
            {
                Console.WriteLine("Type the first name of the Person:");
                InputName.FirstName = Console.ReadLine();
                
                if (InputName.FirstName.Any(Char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. No numbers.");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Type the Last name of the Person:");
                InputName.LastName = Console.ReadLine();

                if (InputName.LastName.Any(Char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. No numbers.");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }

            bool GenderFalse = false;
            while (!GenderFalse)
            {
                Console.WriteLine(
                    "How does the person identify?" +
                    "\n1: Male" +
                    "\n2: Female" +
                    "\n3: NonBinary" +
                    "\n4: Other");

                string GenderInput = Console.ReadLine();
                if (int.TryParse(GenderInput, out int SwitchGender))
                {
                    if (SwitchGender >= 1 && SwitchGender <= 4)
                    {
                        switch (SwitchGender)
                        {
                            case 1:
                                InputGender = Gender.Male;
                                GenderFalse = true;
                                break;

                            case 2:
                                InputGender = Gender.Female;
                                GenderFalse = true;
                                break;

                            case 3:
                                InputGender = Gender.NonBinary;
                                GenderFalse = true;
                                break;

                            case 4:
                                InputGender = Gender.Other;
                                GenderFalse = true;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid input. (1-4)");
                                break;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input correct answer is int (1-4)");
                }
            }

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Please enter birthday of the person. The only valid format is YYYY-MM-DD:");
                string Inputdate = Console.ReadLine();
                if (DateTime.TryParse(Inputdate, out InputDate))
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Invalid input. The only valid format is YYYY-MM-DD");
            }

            while (true)
            {
                Console.WriteLine("Enter hair length: ");
                string InputHairLength = Console.ReadLine();
                if (int.TryParse(InputHairLength, out InputHair.HairLength))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Numbers only.");
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter hair color: ");
                InputHair.HairColor = Console.ReadLine();

                if (InputHair.HairColor.Any(Char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. No numbers.");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter eye color:");
                InputEyeColor = Console.ReadLine();

                if (InputEyeColor.Any(Char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. No numbers.");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }

            Person person = new Person(InputName, InputGender, InputHair, InputEyeColor, InputDate);
            PersonList.Add(person);
        }
        static void ListPerson()
        {
            Console.Clear();
            Console.WriteLine("Here are the people: ");

            foreach (Person person in PersonList)
            {
                Console.WriteLine(person + "\n");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}