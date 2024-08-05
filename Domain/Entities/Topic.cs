

namespace Domain.Entities
{
    public class Topic : BaseEntity
    {
        public string? Title { get; private set; }
        public int NumberOfLessons { get; private set; }
        public int NumberOfTasks { get; private set; }
        public byte TopicProgress { get; private set; }

        
        public string? CourseId { get; private set; }
        public Course? Course { get; private set; }
        public ICollection<Lesson> Lessons { get; private set; } = new List<Lesson>();

        public Topic(string? title, int numberOfLessons, int numberOfTasks, byte topicProgress, string? courseId, Course? course, ICollection<Lesson> lessons)
        {
            Title = title;
            NumberOfLessons = numberOfLessons;
            NumberOfTasks = numberOfTasks;
            TopicProgress = topicProgress;
            CourseId = courseId;
            Course = course;
            Lessons = lessons ?? throw new ArgumentNullException(nameof(lessons));
        }
    }
}
