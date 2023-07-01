class Activity
{
    string _name;
    string _description;
    public int _duration;
    static int _spinnerCounter;

    public Activity()
    {
        _spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string activityName)
    {
        _name = activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        
        Console.Write("How long, in seconds, would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string item in animation)
            {
                Console.Write(item);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
        Console.Write(string.Format("{0}", i));
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        Thread.Sleep(1000);
        }
    }
}