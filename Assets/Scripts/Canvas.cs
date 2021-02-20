using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] bool st;
    public void Deed(bool status)
    {
        if (status)
        {
            st = status;
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
            st = status;
        }
    }
}
