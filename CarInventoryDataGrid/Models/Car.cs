namespace CarInventoryDataGrid.Models;

public class Car
{
    public string? Make { get; set; }

    public string? Model { get; set; }

    public int Year { get; set; }

    public decimal Price { get; set; }

    public string? Engine { get; set; }

    public string? Color { get; set; }

    public Car(string make, string model, int year, decimal price, string engine, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
        Engine = engine;
        Color = color;
    }
}
