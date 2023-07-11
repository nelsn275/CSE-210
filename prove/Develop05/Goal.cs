
public abstract class Goal{

    protected string shortName;

    protected string description;

    protected int points, totalPoints;

    public Goal(string _name, string _description, int _points)
    {
        shortName = _name;
        description = _description;
        points = _points;
    }
    public Goal()
    {
    }

    public void SetGoalName()
    {
        Console.Write("What is the name of your goal: ");
        shortName = Console.ReadLine();
    }

    public string GetName()
    {
        return shortName;
    }

    public void SetDescription()
    {
        Console.Write("What is a short description of this: ");
        description = Console.ReadLine();
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPoints()
    {
        Console.Write("How many points is this goal worth: ");
        points = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return points;
    }

    public abstract void RecordEvent();
        
    public abstract bool IsComplete();

    public virtual string GetStringRepresentation()
    {
             if (IsComplete())
        {
            return $"[X] {GetName()} {GetDescription()}";
        }
        else
        {
            return $"[ ] {GetName()} {GetDescription()}"; 
        }
    }

}