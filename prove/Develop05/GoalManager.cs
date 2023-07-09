
public class GoalManager{
    
    List<Goal> goals = new List<Goal>();
    
    int score;



    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine(score);
    }

    public void AddPoints(int points)
    {
        score += points;
    }

    public void AddToList(Goal goal)
    {
        goals.Add(goal);
    }
}