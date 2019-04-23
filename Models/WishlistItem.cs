using System;
namespace wishlist_react.Models
{
    public class WishlistItem
    {
        public WishlistItem(long UserId, string Description)
        {
            this.UserId = UserId;
            this.Description = Description;
            this.DateAdded = DateTime.UtcNow;
        }

        public long Id { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public float? Cost { get; set; }
        public DateTime DateAdded { get; set; }
        public string Website { get; set; }
    }
}
