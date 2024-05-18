using UnityEngine;

internal class MonsterView : MonoBehaviour
{
     [SerializeField] private ParticleSystem _damageEffect;
    public ParticleSystem damageEffect { get => _damageEffect; }
}