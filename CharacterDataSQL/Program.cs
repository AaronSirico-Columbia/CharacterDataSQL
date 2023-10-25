namespace CharacterDataSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var Path = ($"{Directory.GetCurrentDirectory()}\\Files");
            string File = $"{Path}\\Chars.csv";
            List<Character> Characters = new List<Character>();
            int i = 0;


            using (StreamReader sr = new StreamReader(File))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    if (i < 1)
                    {
                        i++;
                        line = sr.ReadLine();
                    }
                    else
                    {
                        var data = line.Split(',').ToList();
                        Character character = new Character(1, data[0], data[1], data[2], data[3], data[4], data[5]);
                        Characters.Add(character);
                        line = sr.ReadLine();
                    }

                }
            }




        }
    }
}