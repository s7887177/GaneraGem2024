using HurricaneVR.Framework.ControllerInput;
using HurricaneVR.Framework.Core.Utils;
using Unity.VisualScripting;
using UnityEngine;
public class RigidbodyLabelPositionProvider : MonoBehaviour, IPositionProvider
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _offsetY = .15f;

    Vector3 IPositionProvider.position => GetLabelViewPosition();
    private void Reset()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    public Vector3 GetLabelViewPosition()
    {
        var bound = _rigidBody.GetColliderBounds();
        return bound.center + Vector3.up * (bound.size.y / 2+ _offsetY);
    }
}
