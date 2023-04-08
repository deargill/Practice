using MyLibraryClass;

List<string> fishes_1 = new List<string>() { "Нэмо", "Форель" };
Sea sea_1 = new Sea("Адриатическое", 1233, fishes_1);

Sea sea_2 = sea_1.DeepCopy() as Sea;
sea_2.AddFish("Дори");
sea_1.GetInfo();
sea_2.GetInfo();