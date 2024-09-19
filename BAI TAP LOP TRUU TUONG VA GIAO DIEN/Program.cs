public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Phương thức trừu tượng
    public abstract void DisplayProductInfo();

    // Áp dụng giảm giá
    public void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }
}

public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}

public class MobilePhone : Product, ISellable
{
    public MobilePhone(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} mobile phones sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Laptop : Product, ISellable
{
    public Laptop(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} laptops sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Accessory : Product, ISellable
{
    public Accessory(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} accessories sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo các sản phẩm
        MobilePhone phone = new MobilePhone("iPhone 13", 999.99m, 10);
        Laptop laptop = new Laptop("Dell XPS 15", 1599.99m, 5);
        Accessory accessory = new Accessory("Phone Case", 19.99m, 100);

        // Hiển thị thông tin sản phẩm
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Thực hiện bán hàng
        phone.Sell(2);
        laptop.Sell(1);
        accessory.Sell(10);

        // Kiểm tra tồn kho
        Console.WriteLine($"Phone in stock: {phone.IsInStock()}");
        Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");
        Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");

        // Áp dụng giảm giá
        phone.ApplyDiscount(10);
        laptop.ApplyDiscount(15);
        accessory.ApplyDiscount(5);

        // Hiển thị lại thông tin sản phẩm sau khi giảm giá
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}