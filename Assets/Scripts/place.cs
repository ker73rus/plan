using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place : MonoBehaviour
{
    [SerializeField] GameObject untable;
    [SerializeField] GameObject newtable;
    [SerializeField] GameObject player;
    [SerializeField] Vector3 dist;
    [SerializeField] float zero;
    [SerializeField] bool near;
    void Update()
    {
        dist = player.transform.position - transform.position;

        if (Mathf.Abs(dist.x) < 2 && Mathf.Abs(dist.y) < 2)
            near = true;
        else
            near = false;
        
        if(near )
        { if (Input.GetKeyDown(KeyCode.E)) { gameObject.SetActive(false); newtable.SetActive(true); }

           
            player.GetComponent<Player>().pl = true;
            
        }


        
    }
}
