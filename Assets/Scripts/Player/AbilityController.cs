using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Player.Abilities {
    class AbilityController : MonoBehaviour {
        Blink blink;
        Heal heal;
        Immunity immunity;

        void Awake() {
            blink = GetComponent<Blink>();
            heal = GetComponent<Heal>();
            immunity = GetComponent<Immunity>();
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                usekey(GameStats.ab1);


            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                usekey(GameStats.ab2);
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                usekey(GameStats.ab3);
            }
        }
        void usekey(string ab)
        {
            switch (ab)
            {
                case "heal":
                    heal.UseAbility();
                    break;
                case "blink":
                    blink.UseAbility();
                    break;
                case "immunity":
                    immunity.UseAbility();
                    break;

            }
        }
    }
}
