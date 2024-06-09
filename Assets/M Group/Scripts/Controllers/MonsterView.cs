using Sirenix.OdinInspector;
using System.Linq;
using System.Threading;
using UnityEngine;
internal class MonsterView : MonoBehaviour
{
    [SerializeField] private ColliderView _bodyCollider;
    [SerializeField] private ColliderView _weakPointCollider;
     [SerializeField] private ParticleSystem _damageEffect;
    public ParticleSystem damageEffect { get => _damageEffect; }
    internal ColliderView BodyCollider { get => _bodyCollider; }
    internal ColliderView WeakPointCollider { get => _weakPointCollider; }

    [Button]private void AutoFill()
    {
        _bodyCollider = GetComponentsInChildren<ColliderView>().FirstOrDefault(o=>o.name == "Monster");
        _weakPointCollider = GetComponentsInChildren<ColliderView>().FirstOrDefault(o => o.name == "Collider");
    }
}
