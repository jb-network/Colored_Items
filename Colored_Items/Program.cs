// This is challenge work for the "C# Players Guide"
// This is for the Level 30 "Colored Items" Challenge
// This was a Generics Challenge

// Logic used to make the required objects:
// 1 - Make new weapon object
// 2 - Make new ItemCreator using the weapon type
// 3 - Call display method



Sword sword = new Sword();
ItemCreator <Sword> sword1 = new ItemCreator<Sword>(sword, ConsoleColor.Red);
sword1.Display();

Bow bow = new Bow();
ItemCreator<Bow> bow1 = new ItemCreator<Bow>(bow, ConsoleColor.Blue);
bow1.Display();

Axe axe = new Axe();
ItemCreator<Axe> axe1 = new ItemCreator<Axe>(axe, ConsoleColor.Yellow);
axe1.Display();

// <TItem> is used to pass class types into ItemCreator Class
public class ItemCreator<TItem>
{
    public TItem CreatedItem { get; }
    public ConsoleColor Color { get; }

    public ItemCreator(TItem createdItem, ConsoleColor color)
    {
        CreatedItem = createdItem;
        Color = color;
    }
    // Set Color based on Color setting on object, print item, set console back to default setting
    public void Display()
    {
        Console.WriteLine("*****************************");
        Console.WriteLine($"Test for {CreatedItem}:");
        Console.WriteLine("*****************************");
        Console.ForegroundColor = Color;
        Console.WriteLine(CreatedItem);
        Console.ResetColor();
        Console.WriteLine("*****************************\n");
    }
}

// Classes created just to have object to pass into ItemCreator class
public class Sword { }
public class Bow { }
public class Axe { }
