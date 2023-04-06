using ZAD2;

string[] mas1 = new string[5];
Console.WriteLine("Первый массив");
for (int i = 0; i < 5; i++)
{
    mas1[i] = Console.ReadLine();
}
string[] mas2 = new string[5];
Console.WriteLine("Второй массив");
for (int i = 0; i < 5; i++)
{
    mas2[i] = Console.ReadLine();
}
string[] mas3 = new string[3];
Console.WriteLine("Третий массив");
for (int i = 0; i < 3; i++)
{
    mas3[i] = Console.ReadLine();
}

MasClass myClass1 = new MasClass(mas1, 0, 4);
MasClass myClass2 = new MasClass(mas2, 0, 4);
MasClass myClass3 = new MasClass(mas3, 0, 2);

MasClass[] bigMas = new MasClass[3];
bigMas[0] = myClass1;
bigMas[1] = myClass2;
bigMas[2] = myClass3;

bigMas[2].Print();
Console.WriteLine();
Console.WriteLine(bigMas[2] < bigMas[0]);
bigMas[2] = bigMas[0] + bigMas[1];
Console.WriteLine(bigMas[2].StringByIndex(4));
Console.WriteLine();
bigMas[2].PrintByIndex(4);