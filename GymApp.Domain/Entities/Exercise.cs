using GymApp.Domain.ValueObjects;

namespace GymApp.Domain.Entities
{
    public class Exercise
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public List<Set> Sets { get; private set; } = new();

        public Exercise(string name) => Name = name;
        public void AddSet(Set set) => Sets.Add(set);

        public void ChangeName(string newName) => Name = newName;
    }
}
