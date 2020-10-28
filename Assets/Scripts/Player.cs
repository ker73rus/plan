using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed; 
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject table;
    [SerializeField] GameObject untable;
    private bool tab = false;
    public bool pl = false;
    public float rad = 7f;    
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (tab == false) {
                Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, rad);
                foreach(Collider2D hitCollider in hitColliders)
                {
                    hitCollider.SendMessage("Take", SendMessageOptions.DontRequireReceiver);
                    table.SetActive(true);
                    tab = true;
                    pl = !pl;
                }
                
            }
            else
            {
                tab = false;
                table.SetActive(false);
                untable.GetComponent<untable>().un = !untable.GetComponent<untable>().un;
                pl=!pl;
            }
        }
        Vector2 direction = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            direction.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= speed * Time.deltaTime;
        }
        transform.position = direction;
    }
}
