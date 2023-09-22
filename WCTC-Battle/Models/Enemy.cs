namespace WCTC_Battle.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public Leather Leather { get; set; }
        public Sword Sword { get; set; }

        public Enemy()
        {
            Leather = new Leather();
            Sword = new Sword();
        }
    }
}