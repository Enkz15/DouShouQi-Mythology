/***************************************************************************
 * CustomRules.cs
 * -------------------------------------------------------------------------
 * Project       : DouShouQi Mythology
 * Author        : ANGIA Shreya
 * Date          : 04/06/2025
 * Description   : The custom rules of the game
 * -------------------------------------------------------------------------
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouShouQiModel
{
    public class CustomRules : BasicRules
    {
        /// <summary>
        ///  Returns true if a piece is on the fountain  
        /// </summary>
        /// <param name="allPieces"></param>
        /// <returns></returns>
        public bool IsSomeoneOnFountain(List<Piece> allPieces)
        {
            return allPieces.Any(p => WhichCellType(p.Position) == CellType.Fountain);
        }

        /// <summary>
        /// Checks if a piece's skill is activable by verifying its cooldown time and whether it has been used.
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        public static bool IsSkillActivable(Piece piece)
        {
            if (piece.AbilityCooldown == 0)
            {
                return true; // The skill is activable if the cooldown is 0
            }
            else if (!piece.AbilityUsed)
            {
                return true; // The skill is activable if it hasn't been used
            }
            else
            {
                return false; // The skill is not activable if the cooldown is not 0 or his ability has been used
            }
        }

        /// <summary>
        /// Verifies during the game if a piece can activate its ability based on its type and the board state.
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="board"></param>
        /// <param name="allPieces"></param>
        /// <returns></returns> 
        public static bool CanActivateAbility(Piece piece, Board board, List<Piece> allPieces)
        {
            // First checks whether the skill is theoretically activable
            if (!IsSkillActivable(piece))
                return false;

            switch (piece.Ability) 
            {
                case AbilityType.ThunderStrike:
                    // Zeus/Jupiter 
                    return IsEnemyAdjacent(piece, allPieces);

                case AbilityType.ExplosiveSacrifice:
                    // Hades/Pluto 
                    return IsEnemyAdjacent(piece, allPieces);

                case AbilityType.SuperiorKill:
                    // Heracles/Hercules 
                    return IsEnemyStrongerAdjacent(piece, allPieces);

                case AbilityType.DivineShield:
                    // Aphrodite/Venus 
                    return true;

                // Passives → are not activated manually
                case AbilityType.WaterAffinity:
                case AbilityType.DiagonalAttackOnly:
                case AbilityType.TrapImmunity:
                case AbilityType.DoubleMove:
                    return false; 

                default:
                    return false;
            }
        }

        /// <summary>
        /// Checks if there is any enemy nearby
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="allPieces"></param>
        /// <returns></returns>
        private static bool IsEnemyAdjacent(Piece piece, List<Piece> allPieces)
        {
            // List of the four cardinal directions: up, down, left, right
            var adjacentOffsets = new (int dx, int dy)[]
            {
                (0, 1),   // up
                (0, -1),  // down
                (-1, 0),  // left
                (1, 0)    // right  
            };

            foreach (var (dx, dy) in adjacentOffsets)
            {
                var adjacentPos = new Position(piece.Position.X + dx, piece.Position.Y + dy);

                var enemy = allPieces.FirstOrDefault(p =>
                    p.Position.Equals(adjacentPos) &&
                    p.Team != piece.Team &&
                    p.InPlay);

                if (enemy != null)
                    return true;
            }

            return false; 
        }

        /// <summary>
        /// Checks if there is any enemy whose strength is greater than the piece's
        /// </summary>
        /// <param name="piece"></param> 
        /// <param name="allPieces"></param>
        /// <returns></returns>
        public static bool IsEnemyStrongerAdjacent(Piece piece, List<Piece> allPieces)
        {
            // Listing the four directions
            var adjacentCells = new (int dx, int dy)[]
            {
                (0, 1),   // up
                (0, -1),  // down
                (-1, 0),  // left
                (1, 0)    // right   
            };
            foreach (var (dx, dy) in adjacentCells)
            {
                var adjacentPos = new Position(piece.Position.X + dx, piece.Position.Y + dy);
                var enemy = allPieces.FirstOrDefault(p =>
                    p.Position.Equals(adjacentPos) &&
                    p.Team != piece.Team &&
                    p.InPlay &&
                    p.Strength > piece.Strength);
                if (enemy != null)
                    return true;
            }
            return false; 
        }
    }
}