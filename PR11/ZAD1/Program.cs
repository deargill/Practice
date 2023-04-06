using Classes;

Flat flat = new Flat(100, 12, "Vivo");
CentralFlat flat1 = new CentralFlat(100, 12, "Civic", "Younger");
flat.Info();
Console.WriteLine($"Стоимость: {flat.FlatCost()}");
Console.WriteLine();
flat1.Info();
Console.WriteLine($"Стоимость: {flat1.FlatCost()}");