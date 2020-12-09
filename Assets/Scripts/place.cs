using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place : MonoBehaviour
{
    [SerializeField] GameObject untable;
    [SerializeField] GameObject newtable;
    [SerializeField] GameObject player;
    [SerializeField] Vector3 dist;
    [SerializeField] float gip;
   public bool near;
    void Update()
    {
        dist = player.transform.position - transform.position;
        gip = Mathf.Sqrt(Mathf.Pow(dist.x, 2) + Mathf.Pow(dist.y, 2));
        if (gip < 3f)
            near = true;
        else
            near = false; 
    }
    public void PlaceDown()
    {
        gameObject.SetActive(false);
        newtable.SetActive(true);
    }
}
