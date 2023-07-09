
public class ChecklistGoal : Goal{

    int amountCompleted;
    int target;
    int bonusPoints;


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
            AddPoints(GetPoints());
            AddPoints(bonusPoints);
        }
        else
        {
            AddPoints(GetPoints());
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

public override string GetDetailsString(){
    if (IsComplete())
    {
        return $"[X] {GetName()} {GetDescription()} -- Currently Completed {amountCompleted}/{target}";
    }
    else
    {
        return $"[ ] {GetName()} {GetDescription()} -- Currently Completed {amountCompleted}/{target}";

    }
}
    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}