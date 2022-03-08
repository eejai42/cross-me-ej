/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - ssotme odxml42/odxml-to-csharp-pocos
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace crossmegame.Lib.DataClasses
{

    public partial class Game
    {
        public Game()
        {
            this.InitPoco();
            var json = File.ReadAllText("../../../../../SSoT/Airtable.xml.json");
            dynamic data = JsonConvert.DeserializeObject(json);
            var levelsJson = data.Airtable.GameLevels.GameLevel;
            List<GameLevel> levels = JsonConvert.DeserializeObject<List<GameLevel>>(levelsJson.ToString());
            var levelCells = data.Airtable.LevelCells.LevelCell;
            var myCellsJson = levelCells.ToString();
            List<LevelCell> myCells = JsonConvert.DeserializeObject<List<LevelCell>>(myCellsJson);

            levels.ForEach(feLevel =>
            {
                var levelPuzzleCells = myCells.Where(cell => cell.GameName == "Cross Me" && cell.GroupNumber == feLevel.GroupNumber && cell.LevelNumber == feLevel.LevelNumber && cell.CellStateCategory == "Answer");
                var sb = new StringBuilder();
                //sb.AppendLine(feLevel.Name);
                for (var y = 0; y < feLevel.PuzzleHeight; y++)
                {
                    for (var x = 0; x < feLevel.PuzzleWidth; x++)
                    {
                        var levelCell = levelPuzzleCells.FirstOrDefault(cell => cell.X == x && cell.Y == y);
                        if (levelCell is null)
                        {
                            object o = 1;
                        }
                        else
                        {
                            sb.Append(levelCell.CellStateName == "Selected" ? "X" : " ");
                        }
                    }
                    sb.AppendLine();
                }
                var result = sb.ToString();
                File.WriteAllText($"../../../data_Level {feLevel.GroupNumber}.{feLevel.LevelNumber}.txt", result);
            });
            object o = 1;
        }

        public override String ToString()
        {
            return String.Format("Game: {0}", this.Name);
        }

        internal string[,] PrintLevel(int v1, int v2)
        {
            return new string[,] { };
        }
    }
}