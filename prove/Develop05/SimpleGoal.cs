
public class SimpleGoal : Goal{

    bool isComplete;

    public override void RecordEvent()
    {
        AddPoints(GetPoints());
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }


}