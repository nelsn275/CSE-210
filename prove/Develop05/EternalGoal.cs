
public class EternalGoal : Goal{

    public override void RecordEvent()
    {
        AddPoints(GetPoints());
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}