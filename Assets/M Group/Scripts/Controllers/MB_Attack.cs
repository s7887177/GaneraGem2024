using System.Runtime.CompilerServices;
using UnityEngine;


public abstract class MB_Attack : MonsterBehaviour
{
    [SerializeField] private int _attackPoint;

    public int AttackPoint { get => _attackPoint; }

    internal override void Execute()
    {
        Attack();
    }
    protected abstract void Attack();
}
