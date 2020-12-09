using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO.MemoryMappedFiles;
using System.Xml.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed; 
    [SerializeField] Rigidbody2D rb ;
    [SerializeField] GameObject table;
    [SerializeField] GameObject untable, place;
    [SerializeField] bool tab = false;
    [SerializeField] Collider2D[] hitColliders;
    public bool pl = false;
    public float rad = 1f, rad2 = 0.1f;
    private Animator anim;
    public bool check;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void AnimStop()
    {
        anim.SetBool("up", false);
        anim.SetBool("left", false);
        anim.SetBool("down", false);
        anim.SetBool("right", false);

    }

    void Update()
    {
       hitColliders = Physics2D.OverlapCircleAll(transform.position, rad2);
        foreach (Collider2D hitCollider in hitColliders)
        {
            hitCollider.SendMessage("Open", SendMessageOptions.DontRequireReceiver);
        }
        if (check)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hitColliders = Physics2D.OverlapCircleAll(transform.position, rad);
                if (!table.activeSelf)
                {
                    foreach (Collider2D hitCollider in hitColliders)
                    {
                        hitCollider.SendMessage("Take", SendMessageOptions.DontRequireReceiver);
                        if (!hitCollider.isActiveAndEnabled)
                        {
                            
                            place = hitCollider.GetComponent<Table>().place;
                            place.SetActive(true);
                            table.SetActive(true);
                            anim.SetBool("hand", true);
                            anim.Play("handsup");
                            check = false;
                            StartCoroutine("TakeTable");
                        }
                        
                    }

                }
                else if (place.GetComponent<place>().near) 
                {
                    place.GetComponent<place>().PlaceDown();
                        table.SetActive(false);
                 
                    anim.SetBool("hand", false);
                }
            }
            Vector2 direction = transform.position;
            if (Input.GetKey(KeyCode.W))
            {
                direction.y += speed * Time.deltaTime;
                AnimStop();
                anim.SetBool("up", true);
                if (tab)
                {
                    anim.SetBool("hup", true);
                    if (Input.GetKey(KeyCode.S))
                        anim.SetBool("hup", false);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    AnimStop();
                }
                    }
            if (Input.GetKey(KeyCode.S))
            {
                direction.y -= speed * Time.deltaTime;
                AnimStop();
                anim.SetBool("down", true);
                if (tab)
                {
                    anim.SetBool("hdown", true);
                    if (Input.GetKey(KeyCode.W))
                        anim.SetBool("hdown", false);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    AnimStop();
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction.x += speed * Time.deltaTime;
                AnimStop();
                anim.SetBool("right", true);
                if (tab)
                {
                    anim.SetBool("hup", true);
                    if (Input.GetKey(KeyCode.A))
                        anim.SetBool("hup", false);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    AnimStop();
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction.x -= speed * Time.deltaTime;
                AnimStop();
                anim.SetBool("left", true);
                if (tab)
                {
                    anim.SetBool("hdown", true);
                    if (Input.GetKey(KeyCode.D))
                        anim.SetBool("hdown", false);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    AnimStop();
                }
            }
            transform.position = direction;
            if (Input.GetKeyUp(KeyCode.D)){
                anim.SetBool("right", false);
                if (tab)
                {
                    anim.SetBool("hup", false);
                }
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                if (tab)
                {
                    anim.SetBool("hdown", false);
                }
                anim.SetBool("down", false);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                if (tab)
                {
                    anim.SetBool("hup", false);
                }
                anim.SetBool("up", false);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                if (tab)
                {
                    anim.SetBool("hdown", false);
                }
                anim.SetBool("left", false);
            }
        }


       

        }
    IEnumerator TakeTable()
    {
        AnimStop();
        yield return new WaitForSeconds(0.01f);
        yield return new WaitForSeconds (0.1f);
        check = true;
        
    }
}
