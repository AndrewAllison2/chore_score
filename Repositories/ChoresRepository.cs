

namespace chore_score.Repositories;

    public class ChoresRepository
    {
    private List<Chore> dbChores;

    public ChoresRepository()
    {
        dbChores = new List<Chore>();
        dbChores.Add(new Chore("Laundry", 2, false));
        dbChores.Add(new Chore("Dishes", 1, false));
        dbChores.Add(new Chore("Mow Lawn", 2, false));
        dbChores.Add(new Chore("Clean Garage", 4, false));
        dbChores.Add(new Chore("Walk Finn", 1, true));
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore foundChore = dbChores.Find(c => c.Tilte.ToLower() == choreName.ToLower());
        return foundChore;
    }

    internal List<Chore> GetChores()
    {
        return dbChores;
    }
    }
