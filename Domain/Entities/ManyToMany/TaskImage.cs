namespace Domain.Entities.ManyToMany
{
    public class TaskImage : BaseEntity
    {
        public int ImageId { get; private set; }
        public Image? Image { get; private set; }

        public int TaskId { get; private set; }
        public Task? Task { get; private set; }
    }
}
