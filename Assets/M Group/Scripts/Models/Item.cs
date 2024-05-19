using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Item 
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Texture2D _image;
    public int id { get => _id; set => _id = value; }
    public string name { get => _name; }
}
