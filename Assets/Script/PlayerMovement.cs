using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;

    void Update()
    {
        // หมุนซ้ายขวา
        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0f, turn * turnSpeed * Time.deltaTime, 0f);

        // เดินไปตามหน้าที่หันอยู่
        float move = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * move * moveSpeed * Time.deltaTime, Space.World);
    }
}