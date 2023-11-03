/* Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму. 
 * Створіть клас для кожної істоти
Океанаріуму. Вони мають містити інформацію про кожну
морську істоту. Реалізуйте підтримку ітератора для класу
«Океанаріум». Протестуйте можливість використання
foreach для Океанаріуму*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IMarineCreature
{
    string Name { get; set; }
    double Weight { get; set; }
    double Length { get; set; }
    string Species { get; set; }
    string MainFood { get; set; }
}

class Oceanarium
{
    private List<IMarineCreature> inhabitantsOceanarium;

    public Oceanarium()
    {
        inhabitantsOceanarium = new List<IMarineCreature>();
    }

    public void AddInhabitant(IMarineCreature creature)
    {
        inhabitantsOceanarium.Add(creature);
    }

    public IEnumerator<IMarineCreature> GetEnumerator()
    {
        return inhabitantsOceanarium.GetEnumerator();
    }
}

class Dolphin : IMarineCreature
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public string Species { get; set; }
    public string MainFood { get; set; }

    public Dolphin(string name)
    {
        Name = name;
        Weight = 100.0; // Пример веса в кг
        Length = 2.0;  // Пример длины в метрах
        Species = "Дельфин";
        MainFood = "Рыба";
    }
}

class Swordfish : IMarineCreature
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public string Species { get; set; }
    public string MainFood { get; set; }

    public Swordfish(string name)
    {
        Name = name;
        Weight = 200.0; // Пример веса в кг
        Length = 3.0;   // Пример длины в метрах
        Species = "Рыба-Меч";
        MainFood = "Мелкая рыба";
    }
}

class Penguin : IMarineCreature
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public string Species { get; set; }
    public string MainFood { get; set; }

    public Penguin(string name)
    {
        Name = name;
        Weight = 10.0;  // Пример веса в кг
        Length = 0.5;   // Пример длины в метрах
        Species = "Пингвин";
        MainFood = "Рыба и кальмары";
    }
}

class Program
{
    static void Main()
    {
        Oceanarium oceanarium = new Oceanarium();
        oceanarium.AddInhabitant(new Dolphin("Эхо"));
        oceanarium.AddInhabitant(new Swordfish("Сворд"));
        oceanarium.AddInhabitant(new Penguin("Принц"));

        Console.WriteLine("Морские существа в океанариуме:");
        foreach (IMarineCreature creature in oceanarium)
        {
            Console.WriteLine($"Имя: {creature.Name}");
            Console.WriteLine($"Вес: {creature.Weight} кг");
            Console.WriteLine($"Длина: {creature.Length} м");
            Console.WriteLine($"Вид: {creature.Species}");
            Console.WriteLine($"Основная пища: {creature.MainFood}");
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}


