using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBill : MonoBehaviour
{
    private const float JUMP_AMOUT = 50f;

    private Rigidbody2D birdRigiedbody2D;
    public AudioSource jumpSound;
    private void Awake()
    {
        birdRigiedbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        birdRigiedbody2D.velocity = Vector2.up * JUMP_AMOUT;
        jumpSound.Play();
    }

    private void OnCollisionEnter2D()
    {
        Gamecontroller.instanace.BillDies();
    }
}
