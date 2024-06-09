using UnityEngine;

public class MonsterViewManager : MonoBehaviour
{
    [SerializeField] private MonsterManager _monsterManager;
    [SerializeField] private MonsterView[] _data;
    [SerializeField] private IMonsterController _controller;
    [SerializeField] private MB_ChasingPlayer _chasing;
    [SerializeField] private PlayerView _playerView;

    private void Update()
    {
        UpdateChase();
    }
    private void UpdateChase()
    {
        for (int i = 0; i < _data.Length; i++)
        {
        
            _chasing.Chase(_data[i].transform, _playerView.playerWeakPoint.transform, _monsterManager.data[i].speed, _monsterManager.data[i].range);
        }
    }

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
