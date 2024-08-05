


namespace Domain.Entities
{
    public class Course : BaseEntity
    { 
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public string? Icon { get; private set; }

        public ICollection<Topic> Topic { get; private set; } = new List<Topic>();

        public Course(string? title, string? description, string? icon, ICollection<Topic> topic)
        {
            Title = title;
            Description = description;
            Icon = icon;
        }
    }
}
