namespace Rad301_2024_Week2_Lab2
{
    public class Category
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public virtual List<Ad> Ads { get; set; }
    }
}
