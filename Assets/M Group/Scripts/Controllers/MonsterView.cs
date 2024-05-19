using System.Threading;
using UnityEngine;

public interface IMonsterController
{

}



public class MonsterViewManager : MonoBehaviour
{
    [SerializeField] private MonsterView[] _data;
    [SerializeField] private IMonsterController _controller;


    private void RegisterCollisionEvents()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            var collider = _data[i].GetComponent<ColliderView>();
            collider.onTouch += Collider_onTouch;
        }
    }

    private void Collider_onTouch(ColliderView performer, ColliderView receiver)
    {
        switch (performer.Type)
        {
            case ColliderType.MonsterBody:
                if(receiver.Type == ColliderType.Item)
                {
                    
                }
                break;
            case ColliderType.MonsterWeakPoint:
                break;
            default:
                break;
        }

        //_controller
    }

    private void UnegisterCollisionEvents()
    {

    }

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