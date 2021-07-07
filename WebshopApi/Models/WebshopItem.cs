namespace WebshopApi.Models
{
    public class WebshopItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}