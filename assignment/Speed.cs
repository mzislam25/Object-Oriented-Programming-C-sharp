using System.Globalization;

namespace assignment
{
    public class Speed : IFormattable
    {
        private double value;

        public Speed(double value)
        {
            this.value = value;
        }

        public double SpeedInKnot
        {
            get { return value; }
        }

        public double SpeedInMS
        {
            get { return value * 0.5144; }
        }

        public override string ToString()
        {
            return ToString("KN", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "KN";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "KN":
                    return SpeedInKnot.ToString("F2", formatProvider) + " knots";
                case "MS":
                    return SpeedInMS.ToString("F2", formatProvider) + " m/s";
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
