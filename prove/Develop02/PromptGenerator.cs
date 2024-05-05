
class PromptGenerator
{
   private static Random random = new Random();
        private static string GetRandomPrompt()
    {
         string[] prompts = {
            "What helped me continue going throughout the day?",
            "What inspired me the most today?",
            "What was a mistake I made today? How would I fix it?",
            "What was the best part of the day?",
            "What is something you have been pondering today?"
        };
        return prompts[random.Next(0, prompts.Length)];
    }
        
}