using TMPro;
using UnityEngine;

public class LabelViewManager : MonoBehaviour
{
    [SerializeField] private IPositionProvider[] _positions;
    [SerializeField] private ITextProvider[] _texts;
    [SerializeField] private bool _showName;
    [SerializeField] private TextMeshProUGUI _nameLabelPrefab;
    [SerializeField] private Transform _nameLabelViewContainer;
    private TextMeshProUGUI[] _labelViews;

    private void Update()
    {
        CheckShowName();
    }

    private void CheckShowName()
    {
        for (int i = 0; i < _labelViews.Length; i++)
        {
            _labelViews[i].gameObject.SetActive(_showName);
        }
        if (!_showName) return;
        for (int i = 0; i < _labelViews.Length; i++)
        {
            _labelViews[i].transform.position = _positions[i].position;
            _labelViews[i].text = _texts[i].text;
        }
    }
}

