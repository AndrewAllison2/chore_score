

namespace chore_score.Services;

    public class ChoresService
    {
    private readonly ChoresRepository _choresRepository;

    public ChoresService(ChoresRepository choresRepository)
    {
        _choresRepository = choresRepository;
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore chore = _choresRepository.GetChoreByName(choreName);
        return chore;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _choresRepository.GetChores();
        return chores;
    }


    }
