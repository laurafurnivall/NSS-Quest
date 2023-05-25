namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

        public string ShininessDescription()
        {
            string shiny = "no comment";
            if (ShininessLevel <= 2)
            {
                shiny = "dull";
            }
            else if (ShininessLevel > 2 && ShininessLevel <= 5)
            {
                shiny = "noticable";
            }
            else if (ShininessLevel >= 6 && ShininessLevel < 9)
            {
                shiny = "bright";
            }
            else if (ShininessLevel >= 9)
            {
                shiny = "blinding";
            }

            return $"Their hat is {shiny}.";
        }

    }
}