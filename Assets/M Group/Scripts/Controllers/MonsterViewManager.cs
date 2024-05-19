using UnityEngine;

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
