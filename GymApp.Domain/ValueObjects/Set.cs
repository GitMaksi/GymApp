namespace GymApp.Domain.ValueObjects
{
    public class Set
    {
        public int Reps { get; set; }
        public double Weight { get; set; }

        public Set(int reps, double weight)
        {
            Reps = reps;
            Weight = weight;
        }
    }
}
