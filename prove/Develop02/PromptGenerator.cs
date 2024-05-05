
class PromptGenerator
{
   private static Random random = new Random();
        private static string GetRandomPrompt()
    {
         string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What inspired me the most today?",
            "What was a mistake I made today? How would I fix it?",
            "What was the best part of the day?",
            "What is something you have been pondering today?"
        };
        return prompts[random.Next(0, prompts.Length)];
    }
        
}