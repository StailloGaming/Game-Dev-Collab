using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombStoneRandomization : MonoBehaviour
{
    //variables
    public GameObject ghost;
    //public GameObject gem;
    
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
            //SpawnGem();

            Debug.Log("Gem! "+ Random.value);
        }
    }

    void SpawnGhost()
    {
        //instantiates ghosts
        //GameObject newGhost = Instantiate(ghost, new Vector3(0.0832627f, 0.04018606f, -0.02140001f), Quaternion.identity) as GameObject;

        GameObject newGhost = Instantiate(ghost, new Vector3(0.092f, 0.0552f, -0.0185f), Quaternion.AngleAxis(-90, Vector3.right)) as GameObject;

        //makes ghost the child of tombstone
        newGhost.transform.parent = this.gameObject.transform;
    }

    //void SpawnGem()
    //{
    //    //makes gem the child of tombstone
    //    gem.transform.parent = this.gameObject.transform;

    //    //set position for gem
    //    gem.transform.localPosition = new Vector3(-0.0487f, 0.0328f, -0.0082f);
    //}
}
