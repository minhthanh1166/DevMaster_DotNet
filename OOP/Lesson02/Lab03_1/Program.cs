namespace Lab03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car car = new Car()
            {
                make = "Đức quốc xã",
                model = "Mec",
                color = "red",
                year = "2001"
            };

            car.Start();
            car.Stop();

            System.Console.ReadKey();
        }
    }
}
