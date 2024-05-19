using HurricaneVR.Framework.ControllerInput;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed = 1f;
    private HVRGlobalInputs _input;
    private void Awake()
    {
        _input = FindObjectOfType<HVRGlobalInputs>();
    }
    private void Update()
    {
        float yOffset = 0f;
        if(_input.LeftSecondaryButtonState.Active)
        {
            yOffset += 1;
        }
        if(_input.LeftPrimaryButtonState.Active)
        {
            yOffset += -1;
        }
        _player.position += Vector3.up * yOffset *_speed * Time.deltaTime;
    }
}