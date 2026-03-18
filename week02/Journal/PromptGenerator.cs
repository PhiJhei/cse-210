using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
        {
            "What did you like the most about your morning?",
            "What is something that made you smile today?",
            "Something that you're proud of?",
            "Something you’re grateful for right now?",
            "Anything frustrating happen today?"
        };

    public string GetRandomPrompt()
    {
        Random ran = new();

        int item = ran.Next(_prompts.Count);
        return _prompts[ran.Next(_prompts.Count)];
    }
}