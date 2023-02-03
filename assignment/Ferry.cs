namespace assignment
{
    public class Ferry : Vessel
    {
        public int passengers { get; set; }

        public Ferry(string Name, string Year, int Passengers, Speed MaxSpeed) : base(Name, Year, MaxSpeed)
        {
            passengers = Passengers;
        }

        public override string GetVesselInfo()
        {
            return $"Type: {GetType().Name}, Name: {GetName()}, Year_Built: {GetYearBuilt()}, Max_Speed: {GetMaxSpeed()}, Passengers: {passengers}";
        }
    }
}
