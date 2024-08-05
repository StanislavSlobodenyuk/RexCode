
using Domain.Entities.ManyToMany;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Image : BaseEntity
    {

        [Column("FilePathToImage")]
        public string? FilePath { get; private set; }

        public ICollection<LessonImage> LessonImages { get; private set; } = new List<LessonImage>();
        public ICollection<TaskImage> TaskImages { get; private set; } = new List<TaskImage>();


        public Image(string? filePath)
        {
            FilePath = filePath;
        }
    }
}
