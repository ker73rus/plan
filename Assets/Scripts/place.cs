using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place : MonoBehaviour
{
    [SerializeField] GameObject untable;
    [SerializeField] GameObject newtable;
    [SerializeField] GameObject player;
    [SerializeField] Vector3 dist;
    [SerializeField] Vector3 zero;
    [SerializeField] bool near;
    void Update()
    {
        dist = player.transform.position - transform.position;
        if (dist.x < 2 && dist.y < 2)
            near = true;
        else
            near = false;
        if(untable.GetComponent<untable>().un == true && Input.GetKeyDown(KeyCode.E) && near )
        {
            gameObject.SetActive(false);
            newtable.SetActive(true);
            player.GetComponent<Player>().pl = true;
        }


        
    }
}
