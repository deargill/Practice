﻿using Models;

Console.Write("Введите имя: ");
string name = Console.ReadLine();
MyInfo myInfo = new MyInfo(name);

Console.Write($"{myInfo.Name} изменить на: ");
myInfo.Name = Console.ReadLine();