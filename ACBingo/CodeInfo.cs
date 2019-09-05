using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACBingo
{
    class CodeInfo
    {
        public readonly string Name;
        public readonly int Difficulty;
        public readonly string Tag;
        public readonly string Game;
        public readonly bool MultiBingo; //Allows multiple goals of same tag within a bingo if true
        public readonly bool MultiCard; //Allows mulitple goals of same tag within a card if true

        public CodeInfo(string Name, int Difficulty, string Tag, string Game, bool MultiBingo, bool MultiCard)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;
            this.Tag = Tag;
            this.Game = Game;
            this.MultiBingo = MultiBingo;
            this.MultiCard = MultiCard;
        }
    }
}
