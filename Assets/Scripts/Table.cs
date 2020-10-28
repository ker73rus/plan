using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    private bool _near = true;
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
}
