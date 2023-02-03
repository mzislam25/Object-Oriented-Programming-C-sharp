namespace assignment
{
    public class Vessel
    {
        private string name;
        private string yearBuilt;
        private Speed maxSpeed;

        public Vessel(string Name, string Year, Speed MaxSpeed)
        {
            int age = DateTime.Now.Year - int.Parse(Year);
            if (age > 20)
            {
                throw new OldShipException($"{Name} is older than 20 years");
            }
            if (string.IsNullOrEmpty(Name) || Name == "NULL")
            {
                throw new ArgumentNullException(nameof(Name));
            }
            name = Name;
            yearBuilt = Year;
            maxSpeed = MaxSpeed;
        }

        public string GetName()
        {
            return name;
        }
        public string GetYearBuilt()
        {
            return yearBuilt;
        }
        public Speed GetMaxSpeed()
        {
            return maxSpeed;
        }

        public override string ToString()
        {
            return $"Vessel: {name}";
        }

        public virtual string GetVesselInfo()
        {
            return $"Type: {GetType().Name}, Name: {GetName()}, Year_Built: {GetYearBuilt()}, Max_Speed: {GetMaxSpeed()}";
        }

    }
}
