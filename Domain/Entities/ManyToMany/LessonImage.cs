

namespace Domain.Entities.ManyToMany
{
    public class LessonImage : BaseEntity
    {
        public int ImageId { get; private set; }
        public Image? Image { get; private set; }

        public int LessonId { get; private set; }
        public Lesson? Lesson { get; private set; }
    }
}
