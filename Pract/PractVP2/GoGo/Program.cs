using PractVP2;

var list = new List<Figure>();
list.Add(new Circle("Егор", "Белый", 1));
list.Add(new Ring("Кольцо", "Бардовый", 51, 2));
list.Add(new RegularPolygon("Многополигонов,Невероятно", "чёрный", 2, 5));
list.Add(new Square("Квадрат", "Малевича", 21924));

foreach (var item in list)
{
    Console.WriteLine($"{item}\n\n");
}