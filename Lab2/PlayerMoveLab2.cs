using UnityEngine;

public class PlayerMoveLab2 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W)) moveZ = 1f;
        if (Input.GetKey(KeyCode.S)) moveZ = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        Vector3 direction = new Vector3(moveX, 0f, moveZ).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
