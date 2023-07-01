
class ListingActivity : Activity
{
    int _count;
    List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month? ",
        "What are some of your favorite things you have read in the scriptures this month? ",
        "When was a time you prayed for help this week? ",
        "When did you forgive someone this month? "
    };

    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.");
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        string input = "";

        while (DateTime.Now < endTime)
        {
            if (input != "quit")
            {
                Console.Write("> ");
                input = Console.ReadLine();
            }
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(0, _prompts.Count());
        string prompt = _prompts[promptIndex];

        return prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

}