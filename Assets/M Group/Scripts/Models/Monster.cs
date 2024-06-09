using Sirenix.OdinInspector;
using System;
using UnityEngine;

[Serializable]
public struct Monster
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private float _range;
    [SerializeField] private float _speed;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _attackPerformSpeed;
    [SerializeField] private MonsterType _type;
    public int id { get => _id; set => _id = value; }
    public float speed { get => _speed; }
    public float attackSpeed { get => _attackSpeed; }
    public float attackPerformSpeed { get => _attackPerformSpeed; }
    public float range { get => _range; }
    internal MonsterType type { get => _type; }
}


