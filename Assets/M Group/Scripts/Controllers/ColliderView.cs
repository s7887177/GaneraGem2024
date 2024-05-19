using System;
using UnityEngine;

enum ColliderType
{
    Player,
    PlayerWeakPoint,
    PlayerWeapon,
    Door,
    Item,

    MonsterBody,
    MonsterWeakPoint,
    MonsterWeapon,

    Diary,
    PlayerHand
}
internal class ColliderView : MonoBehaviour
{
    [SerializeField] internal event Action<ColliderView, ColliderView> onTouch;
    [SerializeField] private ColliderType _type;

    internal ColliderType Type { get => _type; }

    private void OnCollisionEnter(Collision collision)
    {
        var collider = collision.collider.GetComponent<ColliderView>();
        if (!collider) return;
        onTouch?.Invoke(this, collider);
    }
    private void OnTriggerEnter(Collider other)
    {
        var collider = other.GetComponent<ColliderView>();
        if (!collider) return;
        onTouch?.Invoke(this, collider);
    }
}