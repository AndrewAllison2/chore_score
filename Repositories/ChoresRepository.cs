

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

    internal Chore CreateChore(Chore choreData)
    {
        dbChores.Add(choreData);
        return choreData;
    }

    internal Chore EditChore(string choreName, Chore choreData)
    {
        Chore choreToEdit = dbChores.Find(c => c.Tilte == choreName);
        choreToEdit.Tilte = choreData.Tilte;
        choreToEdit.IsFinished = choreData.IsFinished;
        // dbChores.Add(choreToEdit);
        return choreToEdit;
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

    internal Chore RemoveChore(string choreName)
    {
        Chore choreToFinish = GetChoreByName(choreName);
        dbChores.Remove(choreToFinish);
        return choreToFinish;
    }
}
