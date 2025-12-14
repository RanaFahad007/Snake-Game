using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static Directions direction { get; set; }

        public Settings()
        {
            Width = 20;
            Height = 20;
            direction = Directions.Down;
        }
    }

    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
}