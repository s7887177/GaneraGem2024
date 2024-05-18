using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;
    [SerializeField] private Item _item;
    [SerializeField] private MeshRenderer _renderer;
    public int id { get => _id; set => _id = value; }
    public Item item { get => _item; }

    internal void EditorInitialize(Item item)
    {
        _item = item;
    }
    private void OnEnable()
    {
        
    }

}
