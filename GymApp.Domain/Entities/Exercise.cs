namespace GymApp.Domain.Entities
{
    public class Exercise
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public ICollection<SetEntity> Sets { get; set; } = new List<SetEntity>();

        public Exercise(string name) => Name = name;
        public void AddSet(SetEntity set) => Sets.Add(set);

        public void ChangeName(string newName) => Name = newName;
    }
}
