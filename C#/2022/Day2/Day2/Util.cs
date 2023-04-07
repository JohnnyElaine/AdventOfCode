using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Util
    {

        static string execPath = Assembly.GetEntryAssembly().Location; // Get the path to the current executable
        static string execFolderPath = Path.GetDirectoryName(execPath);
        static string resourcesPath = System.IO.Path.Combine(execFolderPath, @"..\..\..\Resources"); // Go up 3 Levels to the Resources Folder

        public static List<Round> readInput(string filename)
        {
            string filePath = System.IO.Path.Combine(resourcesPath, filename);

            List<Round> rounds = new List<Round>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(' ');

                    int opponentMove = convertMoveToInt(splitLine[0][0]);
                    int myMove = convertMoveToInt(splitLine[1][0]);

                    rounds.Add(new Round(opponentMove, myMove));
                }
            }

            return rounds;
        }

        private static int convertMoveToInt(char  move)
        {
            if (move == 'A' || move == 'X')
            {
                return 1;
            }

            if (move == 'B' || move == 'Y')
            {
                return 2;
            }

            return 3;
        }   
    }
}
