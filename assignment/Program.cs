namespace assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vessel> vessels = new List<Vessel>
            {
                new Ferry("Black Pearl", "2008", 400, new Speed(10)),
                new Tugboat("Interceptor", "2009", 100.44, new Speed(100)),
                new Submarine("Dauntless", "2010", 1500, new Speed(100)),
                new Ferry("Empress", "2008", 500, new Speed(100)),
                new Tugboat("Flying Dutchman", "2009", 200.54, new Speed(100)),
                new Submarine("Endeavour", "2010", 1551, new Speed(100)),
                new Ferry("Black Pearl", "2008", 600, new Speed(100)),
                new Tugboat("Queen Anne's Revenge", "2009", 300.14, new Speed(100)),
                new Submarine("Providence", "2010", 1591, new Speed(100)),
            };
            vessels.ForEach(ve =>
            {
                //Console.WriteLine(ve.ToString());
                Console.WriteLine(ve.GetVesselInfo());
            });
        }
    }
}