using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                _text = $"You win {adventurer.Awesomeness} rubber duckies!";
                Console.WriteLine(_text);
            }
            else if (adventurer.Awesomeness <= 0)
            {
                _text = $"Well this just sucks doesn't it!";
                Console.WriteLine(_text);
            }
        }

    }
}