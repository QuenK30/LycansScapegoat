using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PlayerController;

namespace LycansScapegoat.Services
{
    // Énumération pour les rôles étendus
    public enum ExtendedPlayerRole
    {
        Villager = 0,
        Wolf = 1,
        Hunter = 2,
        Alchemist = 3,
        Scapegoat = 4 // Nouveau rôle ajouté
    }

    // Classe utilitaire pour mapper les rôles étendus vers les rôles originaux
    public static class RoleMapper
    {
        public static PlayerRole MapToPlayerRole(ExtendedPlayerRole extendedRole)
        {
            switch (extendedRole)
            {
                case ExtendedPlayerRole.Villager:
                    return PlayerRole.Villager;
                case ExtendedPlayerRole.Wolf:
                    return PlayerRole.Wolf;
                case ExtendedPlayerRole.Hunter:
                    return PlayerRole.Hunter;
                case ExtendedPlayerRole.Alchemist:
                    return PlayerRole.Alchemist;
                default:
                    throw new NotSupportedException("Rôle non pris en charge");
            }
        }
    }
}