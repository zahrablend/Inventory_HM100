namespace Inventory_HM100
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Storage:");

            var material = new Material("M001", 45)
            {
                Height = 2800,
                Width = 2500,
                ColorCode = "H3176",
                Thickness = 19,
                Color = "Halifax Oak",
                Quantity = 20
            };

            Console.WriteLine($"Storage ID: {material.StorageId}, Price: ${material.Price}, Quantity: ${material.Quantity}");
            Console.WriteLine($"Height: {material.Height}, Width: {material.Width}, ColorCode: {material.ColorCode}, Thickness: {material.Thickness}, Color: {material.Color}");
            

            var handle = new Handle("H001", 25)
            {
                Length1 = 0,
                Length2 = 0,
                Diameter = 25,
                Color = "bronze",
                Style = "Classic",
                Quantity = 50
            };

            Console.WriteLine($"Storage ID: {handle.StorageId}, Price: ${material.Price}, Quantity: ${handle.Quantity}");
            Console.WriteLine($"Diameter: {handle.Diameter}, Style: {handle.Style}, Color: {handle.Color}");
        }
    }
}