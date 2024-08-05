using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[]? TimeStamp { get; set; }
    }
}
