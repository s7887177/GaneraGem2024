using System.Threading;
using UnityEngine;

public interface IMonsterController
{

}
internal class MonsterView : MonoBehaviour
{
    [SerializeField] private ColliderView _bodyCollider;
    [SerializeField] private ColliderView _weakPointCollider;
     [SerializeField] private ParticleSystem _damageEffect;
    public ParticleSystem damageEffect { get => _damageEffect; }
    internal ColliderView BodyCollider { get => _bodyCollider; }
    internal ColliderView WeakPointCollider { get => _weakPointCollider; }
}