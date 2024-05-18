using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Manager", menuName = "M Group/Item Manager")]
public class ItemManager : ScriptableObject
{
    [SerializeField, TableList] private Item[] _data;

    public Item[] data { get => _data; set => _data = value; }

    private void OnValidate()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i].id = i;
        }
    }
}
