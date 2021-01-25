using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emil : MonoBehaviour
{
    [SerializeField] Vector2 mpos;
    [SerializeField] GameObject main;
    [SerializeField] float plo, plx,ply;
    void Update()
    {
        plx = transform.position.x;
        ply = transform.position.y;
       plo = Mathf.Sqrt(Mathf.Pow(mpos.x - transform.position.x, 2) + Mathf.Pow(mpos.y - transform.position.y, 2));
        mpos = Input.mousePosition;
        if ( false)
        {
           
            Destroy(gameObject);
        }
    }
}
