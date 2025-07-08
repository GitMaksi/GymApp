namespace GymApp.Domain.Entities
{
    public class SetEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Reps { get; set; }
        public double Weight { get; set; }

        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = default!;
    }
}
