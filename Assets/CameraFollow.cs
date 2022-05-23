using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update() => transform.position = new Vector3(_target.position.x, _target.position.y, -100f);
}
