namespace ExerciseOopHierarchy;

public abstract class MenuItem
//когато класа е абстрактен, ОБЕКТ  от този клас НЕ може да съществува.Но ако съществуваше ще ми връша каквото пише в тостринг метода.
// Единствената причина да го правим АБСТРАКТЕН е че инскаме да има такъв вид елементи в менюто.Това един вид основа, на кяото ще аправим конкретните елементи от менюто. Ще заготовка, която ни помага да направим неща от тук нататък. 
{
    //пропертита
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // Конструктора
    public MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;

    }
    //Метода Override - това е стринга, който ще връшам когато извикам тостринг.Когато искам да отпечатам някакъв меню айтем.
    public override string ToString()
    {
        return $"{Name} - {Description} - ${Price}";
    }

}
