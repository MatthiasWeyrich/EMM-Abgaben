using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;

    private Vector3 offset;
    private void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void Update() {
        float angle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
