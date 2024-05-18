using Oculus.Interaction;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemView Manager", menuName = "M Group/ItemView Manager")]
public class ItemViewManager : MonoBehaviour
{
    [SerializeField] private ItemManager _itemManager;
    [SerializeField] private ItemView _itemPrefab;
    [SerializeField, TableList] private ItemView[] _itemViews;
    [SerializeField] private Transform _container;
    public ItemView[] itemViews { get => _itemViews; set => _itemViews = value; }

    private void OnValidate()
    {
        for (int i = 0; i < _itemViews.Length; i++)
        {
            _itemViews[i].id = i;
        }
    }

    [Button("Create")]
    private void EditorCreateItemViews()
    {
        var items = _itemManager.data;
        var count = items.Length;
        _itemViews = new ItemView[count];
        EditorCleanItemViews();
    }
    [Button("Clean")]
    private void EditorCleanItemViews()
    {
        if (_itemViews == null) return;
        for (int i = 0; i < _itemViews.Length; i++)
        {
            Object.DestroyImmediate(_itemViews[i].gameObject);
        }
    }
    private void EditorInitializeItem(Item item,ItemView itemView)
    {
        itemView.EditorInitialize(item);
    }
}

