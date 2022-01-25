using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<bulletBill>() != null)
        {
            Gamecontroller.instanace.Birdscored();
        }
    }
}
