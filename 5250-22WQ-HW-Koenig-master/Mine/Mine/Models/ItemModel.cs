using System;

namespace Mine.Models
{
    public class ItemModel
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        //The value of the item +9 damage
        public int Value { get; set; } = 0;
    }
}