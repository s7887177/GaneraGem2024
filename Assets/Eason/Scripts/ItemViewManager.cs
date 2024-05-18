using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemView Manager", menuName = "M Group/ItemView Manager")]
public class ItemViewManager : MonoBehaviour
{
    [SerializeField, TableList] private ItemView[] _data;

    public ItemView[] data { get => _data; set => _data = value; }

    private void OnValidate()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i].id = i;
        }
    }
}

