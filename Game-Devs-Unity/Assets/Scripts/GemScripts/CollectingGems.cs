using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGems : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //if player collides (or "collects") gem, delete gem
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
