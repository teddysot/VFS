using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    enum Colors
    {
        NoColor,
        Brown,
        Cyan,
        Magenta,
        Orange,
        Red,
        Yellow,
        Green,
        Blue
    }

    class Tile
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int OwnerId { get; set; }
        public int House { get; set; }
        public Colors Color;

        public Tile()
        {
            Name = "DEFAULT NAME";
            Price = 0;
            OwnerId = 0;
            House = 0;
            Color = Colors.NoColor;
        }
    }
}
