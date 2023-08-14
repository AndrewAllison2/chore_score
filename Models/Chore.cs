namespace chore_score.Models;

    public class Chore
    {
        public string Tilte { get; set; }
        public int TimeToFinish { get; set; }
        public bool IsFinished { get; set; }


        public Chore(string tilte, int timeToFinish, bool isFinished)
        {
            Tilte = tilte;
            TimeToFinish = timeToFinish;
            IsFinished = isFinished;
        }
    }
