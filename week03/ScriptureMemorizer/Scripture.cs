using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // i need to break the scripture verse into word object parts
        // place those objects inside the _words list
        string[] splitWords = text.Split(' ');

        foreach (var splitWord in splitWords)
        {
            Word word = new Word(splitWord);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rnd.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
        rnd.Next(numberToHide,_words.Count());
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();   
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}