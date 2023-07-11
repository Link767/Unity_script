using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    public float Speed = 5f;
    public float HorizontalSpeed = 10f;
    public static Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal") * HorizontalSpeed * Time.fixedDeltaTime;
        float Vertical = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;

        rb.velocity = transform.TransformDirection(new Vector3(Horizontal, rb.velocity.y, Vertical));
    }
}
