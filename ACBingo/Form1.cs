using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ACBingo
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string outputJSONFile;
        string gameType;
        string bingoDifficulty;
        int bingoLength = 5;            //5 is the standard 5x5 bingo grid
        int taskCount = 19;            //Number of different types of tasks

        int minEasyDifficulty = 1;      //Minimum single difficulty value for a goal on an easy card
        int maxEasyDifficulty = 3;      //Maximum single difficulty value for a goal on an easy card
        int minNormalDifficulty = 3;    //Minimum single difficulty value for a goal on an normal card
        int maxNormalDifficulty = 6;    //Maximum single difficulty value for a goal on an normal card
        int minHardDifficulty = 6;      //Minimum single difficulty value for a goal on an hard card
        int maxHardDifficulty = 10;     //Maximum single difficulty value for a goal on an hard card

        int minEasyRange = 9;           //Minimum sum difficulty value for all bingoes on an easy card
        int maxEasyRange = 11;          //Maximum sum difficulty value for all bingoes on an easy card
        int minNormalRange = 21;        //Minimum sum difficulty value for all bingoes on a normal card
        int maxNormalRange = 24;        //Maximum sum difficulty value for all bingoes on a normal card
        int minHardRange = 34;          //Minimum sum difficulty value for all bingoes on a hard card
        int maxHardRange = 38;          //Maximum sum difficulty value for all bingoes on a hard card

        public Form1()
        {
            InitializeComponent();
            listBoxGame.SelectedIndex = 1;
            listBoxDifficulty.SelectedIndex = 1;
        }

        private void newCard_Click(object sender, EventArgs e)
        {
            outputJSONFile = textBox1.Text;
            switch (listBoxGame.SelectedItem.ToString())
            {
                case "Animal Crossing": gameType = "AC"; break;
                case "Animal Forest e+": gameType = "e+"; break;
                default: break;
            }
            bingoDifficulty = listBoxDifficulty.SelectedItem.ToString();
            

            Tuple<string[,], Color[,]> bingoCardArray = NewBingoGenerate();
            bingoTablePanel.Controls.Clear();
            
            
            for (int i=0; i< bingoLength; i++)
            {
                for (int j=0; j< bingoLength; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = bingoCardArray.Item1[i, j];
                    textBox.BackColor = bingoCardArray.Item2[i, j];
                    textBox.WordWrap = true;
                    textBox.Multiline = true;
                    textBox.Width = 96;
                    textBox.Height = 96;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    bingoTablePanel.Controls.Add(textBox, i, j);
                }
            }
            //MessageBox.Show("Bingo Card Generated!");
        }

        private Tuple <string[,], Color[,]> NewBingoGenerate()
        {
            string[,] bingoCardArray = new string[bingoLength, bingoLength];
            Color[,] bingoCardBackColor = new Color[bingoLength, bingoLength];
            int[,] bingoCardDifficultyArray = new int[bingoLength, bingoLength];
            bool bingoCardPassed = false;
            int bingoDifficultyMinimum = 0;
            int bingoDifficultyMaximum = 0;
            int bingoRangeMinimum = 0;
            int bingoRangeMaximum = 0;



            switch (bingoDifficulty.ToLower())
            {
                case "easy":
                    bingoDifficultyMinimum = minEasyDifficulty;
                    bingoDifficultyMaximum = maxEasyDifficulty;
                    bingoRangeMinimum = minEasyRange;
                    bingoRangeMaximum = maxEasyRange;
                    break;
                case "normal":
                    bingoDifficultyMinimum = minNormalDifficulty;
                    bingoDifficultyMaximum = maxNormalDifficulty;
                    bingoRangeMinimum = minNormalRange;
                    bingoRangeMaximum = maxNormalRange;
                    break;
                case "hard":
                    bingoDifficultyMinimum = minHardDifficulty;
                    bingoDifficultyMaximum = maxHardDifficulty;
                    bingoRangeMinimum = minHardRange;
                    bingoRangeMaximum = maxHardRange;
                    break;
                default: break;
            }

            while (bingoCardPassed == false)
            {
                for (int i = 0; i < bingoLength; i++)
                {
                    for (int j = 0; j < bingoLength; j++)
                    {
                        bingoCardArray[i, j] = null;
                        bingoCardDifficultyArray[i, j] = 0;
                        bingoCardBackColor[i, j] = Color.White;
                    }
                }

                int arrayCounter = 0;

                while (arrayCounter < bingoLength * bingoLength)
                {
                    bool taskPassed = false;
                    int row = rnd.Next(0, bingoLength);
                    int col = rnd.Next(0, bingoLength);

                    while (!string.IsNullOrEmpty(bingoCardArray[row, col]))
                    {
                        row = rnd.Next(0, bingoLength);
                        col = rnd.Next(0, bingoLength);
                    }

                    while (taskPassed == false)
                    {
                        int taskType = rnd.Next(1, taskCount);
                        Color backColor = Color.White;
                        string tagSelect = "";
                        switch (taskType)
                        {
                            case 1: tagSelect = "Insects"; backColor = Color.LightSeaGreen; break;
                            case 2: tagSelect = "Fish"; backColor = Color.CadetBlue; break;
                            case 3: tagSelect = "Series"; backColor = Color.LightPink; break;
                            case 4: tagSelect = "Theme"; backColor = Color.LightGray; break;
                            case 5: tagSelect = "Furniture"; backColor = Color.LightGreen; break;
                            case 6: tagSelect = "Holidays"; backColor = Color.Tan; break;
                            case 7: tagSelect = "Characters"; backColor = Color.LightGoldenrodYellow; break;
                            case 8: tagSelect = "Events"; backColor = Color.Khaki; break;
                            case 9: tagSelect = "Tasks"; backColor = Color.Orange; break;
                            case 10: tagSelect = "Debts"; backColor = Color.Yellow; break;
                            case 11: tagSelect = "Villagers"; backColor = Color.GhostWhite; break;
                            case 12: tagSelect = "Special"; backColor = Color.Red; break;
                            case 13: tagSelect = "Nature"; backColor = Color.Green; break;
                            case 14: tagSelect = "Digging"; backColor = Color.Brown; break;
                            case 15: tagSelect = "HRA"; backColor = Color.RosyBrown; break;
                            case 16: tagSelect = "FengShui"; backColor = Color.Cyan; break;
                            case 17: tagSelect = "Challenges"; backColor = Color.Plum; break;
                            case 18: tagSelect = "Miscellaneous"; backColor = Color.MediumOrchid; break;
                            default: break;
                        }

                        int taskNumber = rnd.Next(0, GoalData.GetCodeInfoArrayLength());
                        Tuple<CodeInfo, int> taskCodeInfo = GoalData.GetTaskCheckByTag(tagSelect, taskNumber);

                        //Checks if the taskNumber fits with the taskType, if the difficulty fits in the correct range, and also if the game type is correct.
                        if (taskCodeInfo.Item2 == 1 && taskCodeInfo.Item1.Game == "All" && taskCodeInfo.Item1.Difficulty >= bingoDifficultyMinimum &&
                            taskCodeInfo.Item1.Difficulty <= bingoDifficultyMaximum || taskCodeInfo.Item2 == 1 && taskCodeInfo.Item1.Game == gameType &&
                            taskCodeInfo.Item1.Difficulty >= bingoDifficultyMinimum && taskCodeInfo.Item1.Difficulty <= bingoDifficultyMaximum)
                        {
                            bool[] taskFailArray = new bool[9]; //0=All Tasks; 1=Tasks to the ->; 2= <-; 3= v; 4= ^; 5= ->, ^; 6= <-, v; 7= ->, v; 8= <-, ^

                            //Checks entire card for same Name and Difficulty or same Tag & false MultiCard
                            for (int i = 0; i < bingoLength; i++)
                            {
                                for (int j = 0; j < bingoLength; j++)
                                {
                                    Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, j]);
                                    if (taskCodeCheckInfo.Item2 == 1)
                                    {
                                        if (taskCodeInfo.Item1.Name == taskCodeCheckInfo.Item1.Name ||
                                            taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag &&
                                            taskCodeCheckInfo.Item1.MultiCard == false)
                                        {
                                            taskFailArray[0] = true;
                                        }
                                    }
                                }
                            }

                            //Checks right of the selected array column for same Tag & false MultiBingo for either goal
                            for (int j = col + 1; j < bingoLength; j++)
                            {
                                Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[row, j]);
                                if (taskCodeCheckInfo.Item2 == 1)
                                {
                                    if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                        taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                    {
                                        taskFailArray[1] = true;
                                    }
                                }
                            }

                            //Checks left of the selected array column for same Tag & false MultiBingo
                            for (int j = col - 1; j >= 0; j--)
                            {
                                Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[row, j]);
                                if (taskCodeCheckInfo.Item2 == 1)
                                {
                                    if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                        taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                    {
                                        taskFailArray[2] = true;
                                    }
                                }
                            }

                            //Checks down of the selected array column for same Tag & false MultiBingo
                            for (int i = row + 1; i < bingoLength; i++)
                            {
                                Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, col]);
                                if (taskCodeCheckInfo.Item2 == 1)
                                {
                                    if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                        taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                    {
                                        taskFailArray[3] = true;
                                    }
                                }
                            }

                            //Checks up of the selected array column for same Tag & false MultiBingo
                            for (int i = row - 1; i >= 0; i--)
                            {
                                Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, col]);
                                if (taskCodeCheckInfo.Item2 == 1)
                                {
                                    if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                        taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                    {
                                        taskFailArray[4] = true;
                                    }
                                }
                            }

                            //Checks tr;bl bingos for same Tag & false MultiBingo
                            if (row + col + 1 == bingoLength)
                            {
                                //Checks right and up of the selected array column for same Tag & false MultiBingo
                                int j = col + 1;
                                for (int i = row - 1; i >= 0; i--, j++)
                                {
                                    Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, j]);
                                    if (taskCodeCheckInfo.Item2 == 1)
                                    {
                                        if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                            taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                        {
                                            taskFailArray[5] = true;
                                        }
                                    }
                                }

                                //Checks left and down of the selected array column for same Tag & false MultiBingo
                                j = col - 1;
                                for (int i = row + 1; i < bingoLength; i++, j--)
                                {
                                    Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, j]);
                                    if (taskCodeCheckInfo.Item2 == 1)
                                    {
                                        if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                            taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                        {
                                            taskFailArray[6] = true;
                                        }
                                    }
                                }
                            }

                            //Checks tl;br bingos for same Tag & false MultiBingo
                            if (row == col)
                            {
                                //Checks right and down of the selected array column for same Tag & false MultiBingo
                                int j = col + 1;
                                for (int i = row + 1; i < bingoLength; i++, j++)
                                {
                                    Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, j]);
                                    if (taskCodeCheckInfo.Item2 == 1)
                                    {
                                        if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                            taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                        {
                                            taskFailArray[7] = true;
                                        }
                                    }
                                }

                                //Checks left and up of the selected array column for same Tag & false MultiBingo
                                j = col - 1;
                                for (int i = row - 1; i >= 0; i--, j--)
                                {
                                    Tuple<CodeInfo, int> taskCodeCheckInfo = GoalData.GetTaskCheckByName(bingoCardArray[i, j]);
                                    if (taskCodeCheckInfo.Item2 == 1)
                                    {
                                        if (taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeInfo.Item1.MultiBingo == false ||
                                            taskCodeInfo.Item1.Tag == taskCodeCheckInfo.Item1.Tag && taskCodeCheckInfo.Item1.MultiBingo == false)
                                        {
                                            taskFailArray[8] = true;
                                        }
                                    }
                                }
                            }


                            if (!taskFailArray.Contains(true))
                            {
                                bingoCardDifficultyArray[row, col] = taskCodeInfo.Item1.Difficulty;
                                bingoCardArray[row, col] = taskCodeInfo.Item1.Name;
                                bingoCardBackColor[row, col] = backColor;
                                taskPassed = true;
                            }
                        }

                    }

                    arrayCounter++;
                }

                //Checks to ensure minimum and maximum difficulty ranges are met for each bingo in both rows and columns
                int[] sumBingoDifficulty = new int[bingoLength * 2 + 2];
                for (int i = 0; i < bingoLength; i++)
                {
                    for (int j = 0; j < bingoLength; j++)
                    {
                        sumBingoDifficulty[i] += bingoCardDifficultyArray[i, j];
                        sumBingoDifficulty[j + bingoLength] += bingoCardDifficultyArray[i, j];
                    }
                }

                int k = 0;
                int l = bingoLength - 1;
                for (int i = 0; i < bingoLength; i++, k++, l--)
                {
                    sumBingoDifficulty[bingoLength * 2] += bingoCardDifficultyArray[k, i];
                    sumBingoDifficulty[bingoLength * 2 + 1] += bingoCardDifficultyArray[l, i];
                }

                bool[] bingoCardPassedArray = new bool[bingoLength * 2 + 2];
                for (int i = 0; i < bingoLength * 2 + 2; i++)
                {
                    if (sumBingoDifficulty[i] >= bingoRangeMinimum && sumBingoDifficulty[i] <= bingoRangeMaximum)
                    {
                        bingoCardPassedArray[i] = true;
                    }
                }

                if (!bingoCardPassedArray.Contains<bool>(false))
                {
                    bingoCardPassed = true;

                    //Finally, if any goals contain Obtain X HRA points, now replace X.
                    for (int i = 0; i < bingoLength; i++)
                    {
                        for (int j = 0; j < bingoLength; j++)
                        {
                            if (bingoCardArray[i, j].StartsWith("Get an HRA Score between X"))
                            {
                                int HRAValue;
                                switch (bingoCardDifficultyArray[i, j])
                                {
                                    case 2:
                                        HRAValue = rnd.Next(2000, 3800);
                                        bingoCardArray[i, j] = String.Format("Get an HRA Score between {0} and {1}", HRAValue, HRAValue + 200); break;
                                    case 3:
                                        HRAValue = rnd.Next(4000, 5900);
                                        bingoCardArray[i, j] = String.Format("Get an HRA Score between {0} and {1}", HRAValue, HRAValue + 100); break;
                                    case 5:
                                        HRAValue = rnd.Next(11000, 12950);
                                        bingoCardArray[i, j] = String.Format("Get an HRA Score between {0} and {1}", HRAValue, HRAValue + 50); break;
                                    case 8:
                                        HRAValue = rnd.Next(20000, 25000);
                                        bingoCardArray[i, j] = String.Format("Get an HRA Score of exactly {0}", HRAValue); break;
                                    default: break;
                                }
                            }
                        }
                    }
                }

            }

            //Writing to the JSON file
            StringBuilder sbBingoJSON = new StringBuilder();
            sbBingoJSON.Append("[ ");
            for (int i = 0; i < bingoLength; i++)
            {
                for (int j = 0; j < bingoLength; j++)
                {
                    if (i == bingoLength - 1 && j == bingoLength - 1)
                    {
                        sbBingoJSON.Append("{\"name\": \"" + bingoCardArray[j, i] + "\"}");
                    }
                    else
                    {
                        sbBingoJSON.Append("{\"name\": \"" + bingoCardArray[j, i] + "\"}," + System.Environment.NewLine);
                    }
                }
            }
            sbBingoJSON.Append(" ]");
            File.WriteAllText(outputJSONFile, sbBingoJSON.ToString());

            return new Tuple<string[,], Color[,]> (bingoCardArray, bingoCardBackColor);
        }
    }
}
