using Sirenix.OdinInspector;
using System;
using UnityEngine;

[Serializable]
public struct Monster
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;
    [SerializeField] private string _name;
    public int id { get => _id; set => _id = value; }
}


