using UnityEngine;

public abstract class MonsterBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _transformView;

    public Transform transformView { get => _transformView; }

    private PlayerView _playerView;
    public PlayerView playerView { get => _playerView; }
    private void Awake()
    {
        _playerView = FindObjectOfType<PlayerView>();
    }
    internal abstract void Execute();

    internal protected void TransitBehaviour<T> () where T : MonsterBehaviour
    {
        var nextBehaviour = this.GetComponent<T>();
        nextBehaviour.enabled = true;
        this.enabled = false;

    }

}
