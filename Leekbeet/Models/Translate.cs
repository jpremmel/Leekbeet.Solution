using System;

namespace Leekbeet.Models
{
    public class LeekbeetTranslator
    {
        public static string Input { get; set; }
        public static string Output { get; set; }

        public static void Translate()
        {
            bool firstCharUpper = Char.IsUpper(Input[0]);
            string[] exceptions = { "and", "the", "a", "I", "but", "also", "in", "of", "for", "to", "with", "are", "I'm", "you", "your", "this", "there", "they're", "their", "am", "if", "is", "was", "my", "at", "that's", "from", "like", "since", "until", "our", "who", "what", "where", "when", "why", "how" };
            string[] inputArray = Input.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool punctuation = false;
                string lastChar = "";
                if (inputArray[i].EndsWith(".") || inputArray[i].EndsWith(",") || inputArray[i].EndsWith("?") || inputArray[i].EndsWith("!"))
                {
                    lastChar = inputArray[i][inputArray[i].Length - 1].ToString();
                    punctuation = true;
                    inputArray[i] = inputArray[i].Remove(inputArray[i].Length - 1);
                }
                int pos = Array.IndexOf(exceptions, inputArray[i]);
                if (pos < 0)
                {
                    if (char.ToLower(inputArray[i][0]) == 'a')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Asparagus";
                        }
                        else
                        {
                            inputArray[i] = "asparagus";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'b')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Beet";
                        }
                        else
                        {
                            inputArray[i] = "beet";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'c')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Carrot";
                        }
                        else
                        {
                            inputArray[i] = "carrot";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'd')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Dill";
                        }
                        else
                        {
                            inputArray[i] = "dill";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'e')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Eggplant";
                        }
                        else
                        {
                            inputArray[i] = "eggplant";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'f')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Fennel";
                        }
                        else
                        {
                            inputArray[i] = "fennel";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'g')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Garlic";
                        }
                        else
                        {
                            inputArray[i] = "garlic";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'h')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Horseradish";
                        }
                        else
                        {
                            inputArray[i] = "horseradish";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'j')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Jicama";
                        }
                        else
                        {
                            inputArray[i] = "jicama";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'k')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Kale";
                        }
                        else
                        {
                            inputArray[i] = "kale";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'l')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Leek";
                        }
                        else
                        {
                            inputArray[i] = "leek";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'm')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Mint";
                        }
                        else
                        {
                            inputArray[i] = "mint";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'n')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Nutmeg";
                        }
                        else
                        {
                            inputArray[i] = "nutmeg";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'o')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Onion";
                        }
                        else
                        {
                            inputArray[i] = "onion";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'p')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Potato";
                        }
                        else
                        {
                            inputArray[i] = "potato";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'q')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Quinoa";
                        }
                        else
                        {
                            inputArray[i] = "quinoa";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'r')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Radish";
                        }
                        else
                        {
                            inputArray[i] = "radish";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 's')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Squash";
                        }
                        else
                        {
                            inputArray[i] = "squash";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 't')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Turnip";
                        }
                        else
                        {
                            inputArray[i] = "turnip";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'u')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Unagi";
                        }
                        else
                        {
                            inputArray[i] = "unagi";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'v')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Vanilla";
                        }
                        else
                        {
                            inputArray[i] = "vanilla";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'w')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Watercress";
                        }
                        else
                        {
                            inputArray[i] = "watercress";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'x')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Xigua";
                        }
                        else
                        {
                            inputArray[i] = "xigua";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'y')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Yam";
                        }
                        else
                        {
                            inputArray[i] = "yam";
                        }
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'z')
                    {
                        if (char.IsUpper(inputArray[i][0]))
                        {
                            inputArray[i] = "Zucchini";
                        }
                        else
                        {
                            inputArray[i] = "zucchini";
                        }
                    }
                }
                if (punctuation)
                {
                    inputArray[i] += lastChar;
                }
            }
            if (firstCharUpper)
            {
                char firstChar = inputArray[0][0];
                string firstWord = inputArray[0].Remove(0, 1);
                inputArray[0] = char.ToUpper(firstChar) + firstWord;
            }
            Output = string.Join(" ", inputArray);
        }
    }
}