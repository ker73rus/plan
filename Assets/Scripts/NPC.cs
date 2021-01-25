using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] GameObject player, canvas;
    [SerializeField] Vector3 dist;
    [SerializeField] float gip;
    public bool near;
    public void Deed()
    {
        canvas.GetComponent<Canvas>().Deed(near);
    }
    void Update()
    {
        dist = player.transform.position - transform.position;
        gip = Mathf.Sqrt(Mathf.Pow(dist.x, 2) + Mathf.Pow(dist.y, 2));
        if (gip < 1.5f)
        {
            near = true;
            Deed();
        }
        else
        {
            near = false;
            Deed();
        }
    }
}
