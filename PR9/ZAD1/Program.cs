using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    struct NOTE
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public int[] birthdate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            NOTE[] notes = new NOTE[2];
            Console.WriteLine("Введите данные восьми человек:");
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine($"Человек {i + 1}:");
                Console.Write("  Фамилия: ");
                notes[i].lastName = Console.ReadLine();
                Console.Write("  Имя: ");
                notes[i].firstName = Console.ReadLine();
                Console.Write("  Номер телефона: ");
                notes[i].phoneNumber = Console.ReadLine();
                Console.Write("  Дата рождения (ДД.ММ.ГГГГ): ");
                string[] birthdateParts = Console.ReadLine().Split('.');
                notes[i].birthdate = new int[] {
                int.Parse(birthdateParts[0]),
                int.Parse(birthdateParts[1]),
                int.Parse(birthdateParts[2])
            };
            }

            Array.Sort(notes, (n1, n2) => string.Compare(n1.lastName, n2.lastName));

            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < notes.Length; i++)
            {
                NOTE note = notes[i];
                if (note.birthdate[1] == month)
                {
                    Console.WriteLine($"{note.lastName} {note.firstName} - {note.birthdate[0]}.{note.birthdate[1]}.{note.birthdate[2]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Нет людей с днем рождения в этом месяце");
            }
        }
    }
}