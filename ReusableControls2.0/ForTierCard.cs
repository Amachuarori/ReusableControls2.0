using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ReusableControls2._0
{
    public struct ForTierCard
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public string SubType { get; set; }
        public Brush Color { get; set; }
        public string Description { get; set; }
    }


    public struct ForTierCards
    {
        public ForTierCard[,] CardsArr;
        public IEnumerable<ForTierCard> Cards => CardsArr?.Cast<ForTierCard>() ?? Array.Empty<ForTierCard>();

        public int Rows => CardsArr?.GetLength(0) ?? 0;
        public int Columns => CardsArr?.GetLength(1) ?? 0;
    }
}
