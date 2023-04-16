using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombStoneRandomization : MonoBehaviour
{
    //variables
    public GameObject ghost;
    public GameObject gem;
    
    void Update()
    {
        //player presses 'E' on tombstone
        if (Input.GetKeyDown(KeyCode.E))
        {
            TombstonePercentage();
        }
    }

    /* 50% chance a ghost appears,
     * 50% chance a gem appears */
    void TombstonePercentage()
    {
        if (Random.value >= 0.5)
        {
            //spawn ghost
            SpawnGhost();

            Debug.Log("Ghost! " + Random.value);
        }

        else if (Random.value < 0.5)
        {
            //spawn gem
            SpawnGem();

            Debug.Log("Gem! "+ Random.value);
        }
    }

    void SpawnGhost()
    {
        //makes ghost the child of tombstone
        ghost.transform.parent = this.gameObject.transform;

        //set position for ghost
        ghost.transform.localPosition = new Vector3(0.0816f, 0.0444f, 0.0239f);
    }

    void SpawnGem()
    {
        //makes gem the child of tombstone
        gem.transform.parent = this.gameObject.transform;

        //set position for gem
        gem.transform.localPosition = new Vector3(-0.0487f, 0.0328f, -0.0082f);
    }
}
