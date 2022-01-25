using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorllingObject : MonoBehaviour
{

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Gamecontroller.instanace.scrollspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamecontroller.instanace.gameover == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
