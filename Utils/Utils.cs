using System.Collections.Generic;
using System.IO;

namespace Blackjack
{
    internal static class Utils
    {
        private static readonly Dictionary<CardNames, int> blackjackValues = new Dictionary<CardNames, int>
        {
            { CardNames.AceOfHearts, 11 },
            { CardNames.TwoOfHearts, 2 },
            { CardNames.ThreeOfHearts, 3 },
            { CardNames.FourOfHearts, 4 },
            { CardNames.FiveOfHearts, 5 },
            { CardNames.SixOfHearts, 6 },
            { CardNames.SevenOfHearts, 7 },
            { CardNames.EightOfHearts, 8 },
            { CardNames.NineOfHearts, 9 },
            { CardNames.TenOfHearts, 10 },
            { CardNames.JackOfHearts, 10 },
            { CardNames.QueenOfHearts, 10 },
            { CardNames.KingOfHearts, 10 },

            { CardNames.AceOfDiamonds, 11 },
            { CardNames.TwoOfDiamonds, 2 },
            { CardNames.ThreeOfDiamonds, 3 },
            { CardNames.FourOfDiamonds, 4 },
            { CardNames.FiveOfDiamonds, 5 },
            { CardNames.SixOfDiamonds, 6 },
            { CardNames.SevenOfDiamonds, 7 },
            { CardNames.EightOfDiamonds, 8 },
            { CardNames.NineOfDiamonds, 9 },
            { CardNames.TenOfDiamonds, 10 },
            { CardNames.JackOfDiamonds, 10 },
            { CardNames.QueenOfDiamonds, 10 },
            { CardNames.KingOfDiamonds, 10 },

            { CardNames.AceOfClubs, 11 },
            { CardNames.TwoOfClubs, 2 },
            { CardNames.ThreeOfClubs, 3 },
            { CardNames.FourOfClubs, 4 },
            { CardNames.FiveOfClubs, 5 },
            { CardNames.SixOfClubs, 6 },
            { CardNames.SevenOfClubs, 7 },
            { CardNames.EightOfClubs, 8 },
            { CardNames.NineOfClubs, 9 },
            { CardNames.TenOfClubs, 10 },
            { CardNames.JackOfClubs, 10 },
            { CardNames.QueenOfClubs, 10 },
            { CardNames.KingOfClubs, 10 },

            { CardNames.AceOfSpades, 11 },
            { CardNames.TwoOfSpades, 2 },
            { CardNames.ThreeOfSpades, 3 },
            { CardNames.FourOfSpades, 4 },
            { CardNames.FiveOfSpades, 5 },
            { CardNames.SixOfSpades, 6 },
            { CardNames.SevenOfSpades, 7 },
            { CardNames.EightOfSpades, 8 },
            { CardNames.NineOfSpades, 9 },
            { CardNames.TenOfSpades, 10 },
            { CardNames.JackOfSpades, 10 },
            { CardNames.QueenOfSpades, 10 },
            { CardNames.KingOfSpades, 10 }
        };

        internal static Dictionary<CardNames, int> BlackjackValues => blackjackValues;
    }
}

