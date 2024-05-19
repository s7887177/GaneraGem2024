using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemView Manager", menuName = "M Group/ItemView Manager")]
public class ItemViewManager : MonoBehaviour
{
    [SerializeField] private ItemManager _itemManager;
    [SerializeField] private ItemView _itemPrefab;
    [SerializeField, TableList] private ItemView[] _itemViews;
    [SerializeField] private Transform _container;
    [SerializeField] private Randomizer _randomizer;

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
        EditorCleanItemViews();
        var items = _itemManager.data;
        var count = items.Length;
        _itemViews = new ItemView[count];
        for (int i = 0; i < count; i++)
        {
            _itemViews[i] = Instantiate(_itemPrefab, _container);
            _itemViews[i].EditorInitialize(items[i]);
        }
    }
    [Button("Clean")]
    private void EditorCleanItemViews()
    {
        if (_itemViews == null) return;
        for (int i = 0; i < _itemViews.Length; i++)
        {
            if (!_itemViews[i]) continue;
            Object.DestroyImmediate(_itemViews[i].gameObject);
        }
        _itemViews = null;
    }
    private void OnEnable()
    {
        for (int i = 0; i < _itemViews.Length; i++)
        {
            _randomizer.Randomize(_itemViews[i].transform);
        }
    }
}

