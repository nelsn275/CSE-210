
class ReflectingActivity : Activity
{
    List <int> tracker = new List<int>();
    List<string> _prompts = new List<string>
    {
        "Think of a time when something was really difficult", 
        "Think of a time when you can remember feeling immense joy",
        "Think of a happy memory",
        "Think of a time when you had to work really hard"
    };
    List<string> _question = new List<string>
    {
        "How did you feel when this experience was complete?",
        "What was your favorite thing about this experience?",
        "Was anyone else a part of this experience? Who?",
        "How did you feel during this experience?"
    };

    Random random = new Random();

    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }


    public void Run()
    {

        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        int interval = GetDuration() / 2;
        for (int i = 0; i <= 1; i++)
        {
            Console.WriteLine();
            DisplayQuestion();
            ShowSpinner(interval);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        int randomPromptIndex = random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[randomPromptIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        int randomQuestionIndex = random.Next(0, _question.Count());
        string randomQuestion = _question[randomQuestionIndex];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"-- {GetRandomPrompt()} --");
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
}