using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster Manager", menuName = "M Group/Monster Manager")]
public class MonsterManager : ScriptableObject
{
    [SerializeField, TableList] private Monster[] _data;

    public Monster[] data { get => _data; set => _data = value; }

    private void OnValidate()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i].id = i;
        }
    }
}
