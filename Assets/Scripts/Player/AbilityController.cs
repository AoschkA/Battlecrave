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

        void Update() {
            if (Input.GetKey(KeyCode.Alpha1)) {
                blink.UseAbility();
            }
            if (Input.GetKey(KeyCode.Alpha2)) {
                heal.UseAbility();
            }
            if (Input.GetKey(KeyCode.Alpha3)) {
                immunity.UseAbility();
            }
        }
    }
}
