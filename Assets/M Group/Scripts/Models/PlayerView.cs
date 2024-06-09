using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [Header("State")]
    [SerializeField] private Player _player;

    [Header("Views") ]
    [SerializeField] private ColliderView _playerWeakPoint;

    internal ColliderView playerWeakPoint { get => _playerWeakPoint; }

    public Vector3 WeakPointWorldPosition => playerWeakPoint.transform.position;
}