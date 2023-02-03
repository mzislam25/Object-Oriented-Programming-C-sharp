namespace assignment
{
    public class Submarine : Vessel
    {
        private double max_depth;
        public Submarine(string Name, string Year, double Max_Depth, Speed MaxSpeed) : base(Name, Year, MaxSpeed)
        {
            max_depth = Max_Depth;
        }

        public override string GetVesselInfo()
        {
            return $"Type: {GetType().Name}, Name: {GetName()}, Year_Built: {GetYearBuilt()}, Max_Speed: {GetMaxSpeed()}, Max_Depth: {max_depth}";
        }
    }
}
