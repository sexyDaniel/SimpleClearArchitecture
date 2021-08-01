namespace SportStore.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
