using System;

class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public Vga Vga { get; set; }
    public Processor Processor { get; set; }

    public Laptop(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} bertipe {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} bertipe {Tipe} mati");
    }

    public virtual void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} bertipe {Tipe} sedang bermain game");
    }

    public virtual void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Asus : Laptop
{
    public Asus(string tipe) : base("Asus", tipe)
    {
    }
}

class Acer : Laptop
{
    public Acer(string tipe) : base("Acer", tipe)
    {
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe) : base("Lenovo", tipe)
    {
    }
}

class Vivobook : Asus
{
    public Vivobook() : base("Vivobook")
    {
    }

    public override void Ngoding()
    {
        Console.WriteLine($"Laptop {Merk} bertipe {Tipe} sedang ngoding");
    }
}

class Swift : Acer
{
    public Swift() : base("Swift")
    {
    }
}

class Predator : Acer
{
    public Predator() : base("Predator")
    {
    }

    public override void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} bertipe {Tipe} sedang bermain game");
    }
}

class Ideapad : Lenovo
{
    public Ideapad() : base("Ideapad")
    {
    }
}

class Legion : Lenovo
{
    public Legion() : base("Legion")
    {
    }
}

class Processor
{
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public Processor(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
    }
}

class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe)
    {
    }
}

class Vga
{
    public string Merk { get; set; }

    public Vga(string merk)
    {
        Merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {
    }
}

class Amd : Vga
{
    public Amd() : base("Amd")
    {
    }
}

class Utama
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.Processor = new Intel("Core i5");
        laptop1.Vga = new Nvidia();

        Laptop laptop2 = new Ideapad();
        laptop2.Processor = new AMD("Ryzen");
        laptop2.Vga = new Amd();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        laptop2.Ngoding();

        Predator predator = new Predator();
        predator.Processor = new Intel("Core i7");
        predator.Vga = new Amd();
        predator.BermainGame();
    }
}