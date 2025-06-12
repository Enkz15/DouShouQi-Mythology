using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouShouQiModel
{
    public enum AbilityType
    {
        Unknown,
        ThunderStrike,        // Zeus / Jupiter : électrocution autour (cooldown 3 tours)
        WaterAffinity,        // Poséidon / Neptune : déplacement dans l'eau (passif)
        ExplosiveSacrifice,   // Hadès / Pluton : explosion (une fois par partie)
        DiagonalAttackOnly,   // Athéna / Minerve : attaque uniquement en diagonale (passif)
        TrapImmunity,         // Héphaïstos / Vulcain : immunité aux pièges adjacents (passif)
        DoubleMove,           // Hermès / Mercure : déplacement de 2 cases (passif)
        DivineShield,         // Aphrodite / Vénus : invincibilité pour 1 tour (cooldown 3 tours)
        SuperiorKill          // Héraclès / Hercule : tuer un adversaire plus fort (une seule fois)
    }

}
