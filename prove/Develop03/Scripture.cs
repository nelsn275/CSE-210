class Scripture
{
    Reference reference;
    List<Word> words;

    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach (string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int numWordstoRemove = random.Next(2, 5);
        int wordsRemoved = 0;
        do
        {
            int randomIndex = random.Next(0, words.Count());
             if (words[randomIndex].GetIsHidden() == false)
             {
                words[randomIndex].Hide();
                wordsRemoved ++;
             }

        } while(numWordstoRemove != wordsRemoved && this.IsCompletelyHidden() == false);
    }
    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach(Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else 
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }


        return ($"{reference.GetDisplayText()} {scriptureText}");
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach(Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }
}