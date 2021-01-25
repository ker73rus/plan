using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    [SerializeField] GameObject text;
    public void Deed(bool status)
    {
        if (status)
            text.SetActive(true);
        else
            text.SetActive(false);
    }
}
