using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    [SerializeField, ReadOnly, TableColumnWidth(30)] private int _id;
    [SerializeField] private Item _item;
    [SerializeField] private TextMeshProUGUI _nameView;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private RigidbodyLabelPositionProvider _positionProvider;
    [SerializeField] private Collider _trigger;
    public int id { get => _id; set => _id = value; }
    public Item item { get => _item; }

    internal void EditorInitialize(Item item)
    {
        _item = item;
        _nameView.text = _item.name;
    }
    private void Update()
    {
        _nameView.text = _item.name;
        _nameView.transform.position = _positionProvider.GetLabelViewPosition();
        _nameView.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Vector3.up);
    }
}
