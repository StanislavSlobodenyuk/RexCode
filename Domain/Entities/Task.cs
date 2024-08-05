
using Domain.Entities.ManyToMany;

namespace Domain.Entities
{
    public class Task : BaseEntity
    {
        public string? Title { get; private set; }
        public string? TaskDescription { get; private set; }
        public string CorrectSolution { get; private set; }
        public byte Grade { get; private set; }

        public Lesson? Lesson { get; private set; }
        public int LessonId { get; private set; }

        public ICollection<TaskImage> TasksImages { get; private set; } = new List<TaskImage>();

        public Task(string? title, string? taskDescription, string correctSolution, byte grade, Lesson? lesson, int lessonId, ICollection<TaskImage> tasksImages)
        {
            Title = title;
            TaskDescription = taskDescription;
            CorrectSolution = correctSolution;
            Grade = grade;
            Lesson = lesson;
            LessonId = lessonId;
            TasksImages = tasksImages ?? throw new ArgumentNullException(nameof(tasksImages));
        }
    }
}
