using LycansScapegoat.Services;
using UnityEngine;
using UnityEngine.XR;

namespace LycansScapegoat.Patchs
{
    public class PlayerControllerPatch : PlayerController
    {
        // Propriété pour le rôle étendu
        public static ExtendedPlayerRole ExtendedRole { get; set; }

        // Méthode pour initialiser les fonctionnalités spéciales
        public static void Hook()
        {
            if (ExtendedRole == ExtendedPlayerRole.Scapegoat)
            {
                HandleScapegoatRole();
            }
        }

        // Logique spécifique pour le rôle de bouc émissaire
        private static void HandleScapegoatRole()
        {
            // Utilise une méthode de logging appropriée pour ton projet
            Log.Info("HandleScapegoatRole");


            var locaPlayer = Local;

            if (locaPlayer != null && locaPlayer.HasStateAuthority)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                                       // On récupère au hasard un des sons de pets existants
                    string text = "FART_" + Random.Range(1, 9);
                    // On broadcast le son que l'on souhaite lancer
                    GameManager.Rpc_BroadcastFollowSound(locaPlayer.Runner, text, locaPlayer.transform.position, 25);
                    Log.Debug($"Playing sound {text}");
                }
            }
        }
    }
}