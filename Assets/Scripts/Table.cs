using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField] GameObject player, canvas;
    [SerializeField] Vector3 dist;
    [SerializeField] float gip;
    public bool _near = true, near2;
    public GameObject place;
    [SerializeField] GameObject untable;
    public void Take()
    {
        if (_near)
        {
            gameObject.SetActive(false); untable.GetComponent<untable>().un = false;
        }
        else
            gameObject.SetActive(true);
        _near = !_near;
    }

    private void Update()
    {
        if (player.transform.position.y > transform.position.y)
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
        else gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
        dist = player.transform.position - transform.position;
        gip = Mathf.Sqrt(Mathf.Pow(dist.x, 2) + Mathf.Pow(dist.y, 2));
        Deed();
    }
    public void Deed()
    {
        if (gip < 1.5f)
        {
            near2 = true;
            canvas.GetComponent<Canvas>().Deed(near2);
        }
        else if (gip > 1.5f && gip < 2.0f)
        {
            canvas.GetComponent<Canvas>().Deed(near2); near2 = false; }
    }
}
