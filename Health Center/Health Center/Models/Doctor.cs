using Health_Center.Models.Base;

namespace Health_Center.Models
{
    public class Doctor: BaseEntity
    {
        public string Name  { get; set; }
        public string Position  { get; set; }
        public string Image { get; set; }
    }
}
