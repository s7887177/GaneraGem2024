using Sirenix.OdinInspector;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;

    public int id { get => _id; set => _id = value; }
}
