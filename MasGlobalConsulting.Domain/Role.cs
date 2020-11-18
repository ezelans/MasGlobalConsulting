namespace MasGlobalConsulting.Domain
{
    public class Role
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
