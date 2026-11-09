
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the most interesting thing you learned today?",
        "What made you happy today?",
        "What challenge did you overcome today?",
        "What is one thing you are grateful for?",
        "What would you like to improve about yourself?",
        "Describe a moment today that made you think deeply.",
        "What is one goal you want to achieve this week?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}