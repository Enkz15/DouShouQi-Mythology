using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouShouQiModel
{
    public sealed class Position : IEquatable<Position>
    {
        /// <summary>
        /// Représente les x et y par rapport aux plateau
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }

        public Position() { }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Vérifie si la position est égale à une autre position
        /// </summary>
        /// <param name="pos">Position à vérifier</param>
        /// <returns></returns>
        public bool Equals(Position? pos)
        {
            if (ReferenceEquals(pos, null)) return false;
            if (ReferenceEquals(this, pos)) return true;
            return X == pos.X && Y == pos.Y;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Position);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
