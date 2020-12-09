using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    private bool _near = true;
    [SerializeField] GameObject untable;[SerializeField] GameObject player;
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
    }
}
