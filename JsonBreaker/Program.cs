using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace JsonBreaker
{
    class Program
    {
        #region Private Variables
        private const string INPUT_PATH = @"D:\test-folder\pokedex-splitting\pokedex.json";
        private const int NUMBER_PER_SET = 6;
        private const string OUTPUT_PATH = @"D:\test-folder\pokedex-splitting\output";
        #endregion

        #region Composition Root
        private static void Main(string[] args)
        {
            var jsonString = File.ReadAllText(INPUT_PATH);
            var jsonArray = JArray.Parse(jsonString);
            var iterations = jsonArray.Count / NUMBER_PER_SET;
            var remainders = jsonArray.Count % NUMBER_PER_SET;

            if (remainders > 0)
                iterations += 1;

            for (var i = 0; i < iterations; i++) {
                var iterationMembers = jsonArray.Skip(i * NUMBER_PER_SET)
                                                .Take(NUMBER_PER_SET);

                var path = OUTPUT_PATH + "\\" + (i + 1) + ".json";

                File.WriteAllText(path, (new JArray(iterationMembers)).ToString());
            }

            Console.Read();
        }
        #endregion
    }
}
