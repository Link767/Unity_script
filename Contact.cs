using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    [SerializeField] private float push = 700f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Block")
        {
            MovePlayer.rb.AddForce(new Vector3(0, 1, -5) * push);
        }
    }
}
