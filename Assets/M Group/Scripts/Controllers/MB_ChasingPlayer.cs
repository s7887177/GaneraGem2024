using UnityEngine;
class MB_ChasingPlayer : MonoBehaviour
{
    public bool Chase(Transform monster, Transform player, float speed, float stopChasingDistance) 
    {
        GetDistanceToPlayer(monster, player, out var diff, out var dist, out var unit);
        if (dist < stopChasingDistance) return false;
        monster.position += speed * Time.deltaTime * unit;
        monster.rotation = Quaternion.LookRotation(unit, Vector3.up);
        return true;
    }
    internal void GetDistanceToPlayer(Transform from, Transform to, out Vector3 diff, out float distance, out Vector3 unit)
    {
        diff = to.position - from.position;
        diff.y = 0;
        distance = diff.magnitude;
        unit = diff.normalized;
        unit.y = 0;
    }
}
