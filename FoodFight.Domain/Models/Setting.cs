namespace FoodFight.Domain.Models
{
    public class Setting : DomainObject
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }
    }
}