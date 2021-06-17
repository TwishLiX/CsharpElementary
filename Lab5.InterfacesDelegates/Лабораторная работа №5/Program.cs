using System;
using System.Collections.Generic;

namespace Лабораторная_работа__5
{
    class Program
    {
        public static List<Drawing> list = new List<Drawing>();
        delegate void Multicast();
        static Multicast multicast;
        public static IAdd edit;
        public static IDelete delete = new Drawing();
        static void Main(string[] args)
        {
            int action;
            do
            {
                Console.WriteLine("Choose an action:\n1 - Add element\n2 - Delete element\n3 - View list\n0 - Exit\nInput: ");
                action = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                if (action == 1)
                {
                    do
                    {
                        Console.WriteLine("Choose what to add or other action.\n1 - Drawing\n2 - Picture\n3 - Reproduction\n4 - Landscape\n5 - Back to main menu\n0 - Exit\nInput:");
                        action = Convert.ToInt32(Console.ReadLine());
                        switch (action)
                        {
                            case 1:
                                edit = new Drawing();
                                multicast = edit.Add;
                                multicast += Output;
                                multicast();
                                break;
                            case 2:
                                edit = new Picture();
                                multicast = edit.Add;
                                multicast += Output;
                                multicast();
                                break;
                            case 3:
                                edit = new Reproduction();
                                multicast = edit.Add;
                                multicast += Output;
                                multicast();
                                break;
                            case 4:
                                edit = new Landscape();
                                multicast = edit.Add;
                                multicast += Output;
                                multicast();
                                break;
                            case 5:
                                Console.Write("\n");
                                break;
                            case 0:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Incorrect. Try again.\n");
                                break;
                        }
                    } while (action != 5);
                }
                if (action == 2)
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.\n");
                    }
                    else
                    {
                        multicast = delete.Delete;
                        multicast();
                        if (list.Count > 0)
                        {
                            Output();
                        }
                    }
                }
                if (action == 3)
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.\n");
                    }
                    else
                    {
                        Output();
                    }
                }
                if (action == 0)
                {
                    Environment.Exit(0);
                }
                else if (action != 1 && action !=2 && action != 3 && action != 0 && action != 5)
                {
                    Console.WriteLine("Error. Try again.\n");
                }
            } while (action != 0);
            Console.ReadKey();
        }
        public static void Output()
        {
            Console.WriteLine("\nInformation about all collections:\n");
            foreach (var item in list)
                Console.WriteLine(item);
            Console.Write("\n");
        }
    }

    interface IAdd
    {
        void Add();
    }

    interface IDelete
    {
        void Delete();
    }

    class Drawing : IAdd, IDelete
    {
        private protected string Author { get; set; }
        private protected int Year { get; set; }

        public Drawing()
        {
        }

        public Drawing(string author, int year)
        {
            Author = author;
            Year = year;
        }

        void IAdd.Add()
        {
            Console.Write("\nInput name of the author: ");
            Author = Console.ReadLine();
            Console.Write("Input the year: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Addition(Author, Year);
        }

        void IDelete.Delete()
        {
            int index;
            do
            {
                Console.WriteLine("Input an index of the element you want to delete: ");
                index = Convert.ToInt32(Console.ReadLine());
                if (index < 0 || index >= Program.list.Count)
                {
                    Console.WriteLine("Index is out of range.");
                }
            } while (index < 0 || index >= Program.list.Count);
            Program.list.RemoveAt(index);
            Console.WriteLine("\nElements were successfully deleted.\n");
        }

        public void Addition(string author, int year)
        {
            Program.list.Add(new Drawing(author, year));
        }

        public override string ToString()
        {
            return $"Author: {Author}, Year: {Year}";
        }
    }

    class Picture : Drawing, IAdd
    {
        private protected string Title { get; set; }

        public Picture()
        {
        }

        public Picture(string title, string author, int year) : base(author, year)
        {
            Title = title;
        }

        void IAdd.Add()
        {
            Console.Write("\nInput name of the author: ");
            Author = Console.ReadLine();
            Console.Write("Input the year: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the title: ");
            Title = Console.ReadLine();
            Addition(Title, Author, Year);
        }

        virtual public void Addition(string title, string author, int year)
        {
            Program.list.Add(new Picture(title, author, year));
        }

        public override string ToString()
        {
            return base.ToString() + $", Title: {Title}";
        }
    }

    class Reproduction : Picture
    {
        public Reproduction()
        {
        }

        public Reproduction(string title, string author, int year) : base(title, author, year)
        {
        }

        override public void Addition(string title, string author, int year)
        {
            Program.list.Add(new Reproduction(title, author, year));
        }

        public override string ToString()
        {
            return base.ToString() + " (Reproduction)";
        }
    }

    class Landscape : Picture, IAdd
    {
        private string Place { get; set; }

        public Landscape()
        {
        }

        public Landscape(string place, string title, string author, int year) : base(title, author, year)
        {
            Place = place;
        }

        void IAdd.Add()
        {
            Console.Write("\nInput name of the author: ");
            Author = Console.ReadLine();
            Console.Write("Input the year: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the title: ");
            Title = Console.ReadLine();
            Console.Write("Input a place: ");
            Place = Console.ReadLine();
            Addition(Place, Title, Author, Year);
        }

        public void Addition(string place, string title, string author, int year)
        {
            Program.list.Add(new Landscape(place, title, author, year));
        }

        public override string ToString()
        {
            return base.ToString() + $", Place: {Place}";
        }
    }
}
