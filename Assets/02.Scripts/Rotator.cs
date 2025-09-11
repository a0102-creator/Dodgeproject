using UnityEngine;

public class Rotator : MonoBehaviour {
    public float rotationSpeed = 45f;

    void Update() {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
