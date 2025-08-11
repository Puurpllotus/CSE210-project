using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Test individual shapes
        Square sq = new Square("Red", 4);
        Console.WriteLine($"Square - Color: {sq.GetColor()}, Area: {sq.GetArea()}");

        Rectangle rect = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle - Color: {rect.GetColor()}, Area: {rect.GetArea()}");

        Circle circ = new Circle("Green", 2.5);
        Console.WriteLine($"Circle - Color: {circ.GetColor()}, Area: {circ.GetArea():0.00}");

        Console.WriteLine("\n--- Polymorphism in Action ---");

        // Step 2: Store shapes in a List<Shape>
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Yellow", 7));
        shapes.Add(new Rectangle("Purple", 6, 3));
        shapes.Add(new Circle("Orange", 3));

        // Step 3: Iterate through the list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape has an Area of {shape.GetArea():0.00}");
        }
    }
}
