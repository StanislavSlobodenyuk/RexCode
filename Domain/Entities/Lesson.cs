using Domain.Entities.ManyToMany;
using Domain.Enums;

namespace Domain.Entities
{
    public class Lesson : BaseEntity
    {
        public string? Title { get; private set; }
        public string? Content {  get; private set; }
        public byte LessonProgress { get; private set; }
        public DifficultLesson DifficultLesson { get; private set; } 
        public ImportantLesson ImportantLesson { get; private set; }

        public ICollection<LessonImage> LessonImages { get; private set; } = new List<LessonImage>();
        public ICollection<Task> Tasks { get; private set; } = new List<Task>();

        public Topic? Topic { get; private set; }
        public int TopicId { get; private set; }

        public Lesson(string? title, string? content, byte lessonProgress, DifficultLesson difficultLesson, ImportantLesson importantLesson, Topic? topic, int topicId)
        {
            Title = title;
            Content = content;
            LessonProgress = lessonProgress;
            DifficultLesson = difficultLesson;
            ImportantLesson = importantLesson;
            Topic = topic;
            TopicId = topicId;
        }
    }
}
