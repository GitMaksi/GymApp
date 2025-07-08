using GymApp.Domain.Enums;

namespace GymApp.Domain.Entities
{
    public class Workout
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public TrainingDayType TrainingDay { get; set; }
        public string? CustomName { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();

        public Workout(TrainingDayType trainingDay)
        {
            Date = DateTime.UtcNow.Date;
            TrainingDay = trainingDay;
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
