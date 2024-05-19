using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField] private Bounds _bounds;

    internal void Randomize(Transform transform)
    {
        transform.position = new Vector3
        (
            Random.Range(_bounds.min.x, _bounds.max.x),
            Random.Range(_bounds.min.y, _bounds.max.y),
            Random.Range(_bounds.min.z, _bounds.max.z)
        );
        transform.position += _bounds.center;
        transform.rotation = Quaternion.Euler
        (
            Random.Range(-180, 180),
            Random.Range(-180, 180),
            Random.Range(-180, 180)
        );
    }
}