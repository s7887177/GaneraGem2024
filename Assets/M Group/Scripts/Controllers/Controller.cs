using OVR.OpenVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    private void Execute(ColliderView performer, ColliderView receiver)
    {
        var monsterView = receiver.GetComponent<MonsterView>();
        monsterView.damageEffect.Play();
    }
}
