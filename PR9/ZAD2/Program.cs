using Сlasses;

Accauntant accauntant = new();

int hours = Convert.ToInt32(MyLibrary.Input("Введите кол-во часов: "));

if (accauntant.AskForBonus(Post.director, hours))
{
    Console.WriteLine("Премия положена");
}
else
{
    Console.WriteLine("Премия не положена");
}