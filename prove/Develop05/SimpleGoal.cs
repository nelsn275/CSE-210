
public class SimpleGoal : Goal{

    bool isComplete;

    public SimpleGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete) : base (_goalName, _goalDescription, _points)
    {
        isComplete = _goalComplete = false;
    }
    public SimpleGoal()
    {
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }


}