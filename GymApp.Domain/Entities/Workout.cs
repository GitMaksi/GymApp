using GymApp.Domain.Enums;

namespace GymApp.Domain.Entities
{
    public class Workout
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; private set; } = DateTime.UtcNow;
        public TrainingDayType TrainingDay { get; private set; }
        public List<Exercise> Exercises { get; private set; } = new();

        public Workout(TrainingDayType trainingDay)
        {
            TrainingDay = trainingDay;
        }

        public void AddExercise(Exercise exercise) => Exercises.Add(exercise);
    }
}
