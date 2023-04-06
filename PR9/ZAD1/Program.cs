using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
void Print(NOTE note)
{
    Console.WriteLine($"{note.name} {note.surname}");
    Console.WriteLine($"Номер: {note.number}");
    Console.Write($"{note.birthday[0]}.{note.birthday[1]}.{note.birthday[2]}");
    Console.WriteLine();
}
void Search(NOTE[] notes, string sSurname)
{
    for (int i = 0; i < notes.Length; i++)
    {
        if (notes[i].surname == sSurname)
        {
            Print(notes[i]);
        }
    }

}
void Sort(ref NOTE[] mass)
{
    mass = mass.OrderBy(i => i.number).ToArray();
}

NOTE[] myNote = new NOTE[2];
for (int i = 0; i < myNote.Length; i++)
{
    Console.WriteLine($"{i + 1} запись");
    Console.Write("Введите имя: ");
    myNote[i].name = Console.ReadLine();
    Console.Write("Введите фамилию: ");
    myNote[i].surname = Console.ReadLine();
    Console.Write("Введите номер телефона: ");
    myNote[i].number = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите дату рождения:");
    Array.Resize(ref myNote[i].birthday, 3);
    for (int j = 0; j < myNote[i].birthday.Length; j++)
    {
        switch (j)
        {
            case 0: Console.Write("День: "); break;
            case 1: Console.Write("Месяц: "); break;
            case 2: Console.Write("Год: "); break;
        }
        myNote[i].birthday[j] = int.Parse(Console.ReadLine());
    }
}
Sort(ref myNote);
for (int i = 0; i < myNote.Length; i++)
{
    Console.WriteLine();
    Print(myNote[i]);
}
Console.WriteLine("\nРезультат поиска:");
Search(myNote, "Климчук");

struct NOTE
{
    public string name, surname;
    public int number;
    public int[] birthday;
}