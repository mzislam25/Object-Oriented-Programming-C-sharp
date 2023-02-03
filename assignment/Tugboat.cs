namespace assignment
{
    public class Tugboat : Vessel
    {
        private double max_force;
        public Tugboat(string Name, string Year, double Max_Force, Speed MaxSpeed) : base(Name, Year, MaxSpeed)
        {
            max_force = Max_Force;
        }

        public override string GetVesselInfo()
        {
            return $"Type: {GetType().Name}, Name: {GetName()}, Year_Built: {GetYearBuilt()}, Max_Speed: {GetMaxSpeed()}, Max_Force: {max_force}";
        }
    }

}
