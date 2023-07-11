
public class GoalManager{
    
    List<string> goals = new List<string>();
    
    int score;
    int count = 1;


    public void DisplayGoals()
    {
        foreach (string goal in goals)
        {
            Console.WriteLine($"{count}. {goal}");
            count ++;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddPoints(int points)
    {
        score += points;
    }

    public void AddToList(string goalInfo)
    {
        goals.Add(goalInfo);
    }
}