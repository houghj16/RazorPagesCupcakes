namespace RazorPagesCupcakes.Models
{
    public readonly struct Distance
    {
        public readonly double Magnitude { get; }

        public readonly double Direction { get; }

        public Distance(double dx, double dy) // Use primary constructor
        {
            Magnitude = Math.Sqrt(dx * dx + dy * dy);
            Direction = Math.Atan2(dy, dx);
        }
    }
}
