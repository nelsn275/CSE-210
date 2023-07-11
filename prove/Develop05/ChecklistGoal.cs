
public class ChecklistGoal : Goal{

    int amountCompleted;
    int target;
    int bonusPoints;

    public ChecklistGoal(string _goalName, string _goalDescription, int _points, int _bonuspoints, int _target, int _amountCompleted) : base (_goalName, _goalDescription, _points)
    {
        amountCompleted = _amountCompleted;
        target = _target;
        bonusPoints = _bonuspoints;
    }
    public ChecklistGoal()
    {
    }

    public void SetTarget()
    {
        Console.Write("How many times do you want to complete this goal: ");
        target = int.Parse(Console.ReadLine());
    }

    public void SetBonusPoints()
    {
        Console.Write("What is the bonus for completing it that many times?");
        bonusPoints = int.Parse(Console.ReadLine());
    }
    public override void RecordEvent()
    {
        amountCompleted +=1;
        if (IsComplete())
        {
            ;
        }
        else
        {
            ;
        }
    }

    public override bool IsComplete()
    {
        if (amountCompleted == target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[X] {GetName()} {GetDescription()} -- Currently Completed {amountCompleted}/{target}";
        }
        else
        {
            return $"[ ] {GetName()} {GetDescription()} -- Currently Completed {amountCompleted}/{target}";
        }
    }
}