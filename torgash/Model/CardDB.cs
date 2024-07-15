using Microsoft.EntityFrameworkCore;

namespace torgash.Model.Cards
{
    public class CardDB: DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardDB(DbContextOptions<CardDB> options): base(options)
        {

        }
    }

    
}
