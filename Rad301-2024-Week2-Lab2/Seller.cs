namespace Rad301_2024_Week2_Lab2
{
    public class Seller
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual List<Ad> Ads { get; set; }
    }
}
