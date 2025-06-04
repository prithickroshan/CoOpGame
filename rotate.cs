using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    Rigidbody body;
    Animator animator;
    public GameObject ROCKET;
    int counter = 0;
    public GameObject landMine;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        float mouse = Input.GetAxisRaw("Mouse X");
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walking", true);
            body.velocity=new Vector3(transform.forward.x,0,transform.forward.z)*4;
        }
        if(Input.GetKey(KeyCode.W)==false)
        {
            animator.SetBool("walking", !true);
            body.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * 0;
        }
        if(mouse>0)
        {
            transform.Rotate(0,1,0);
        }
        if(mouse<0)
        {
            transform.Rotate(0, -1, 0);
        }
        if(Input.GetMouseButtonDown(0)&&counter==0)
        {
            Instantiate(ROCKET, transform.position, Quaternion.Euler(new Vector3(338.085999f, 4.23000431f, 278.122009f)));
            StartCoroutine(timer());
        }
        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(landMine,transform.position,Quaternion.Euler(new Vector3(270.697174f, 39.3772888f, 344.696106f)));
        }

    }
    IEnumerator timer()
    {
        counter = 1;
        yield return new WaitForSeconds(30);
        counter = 0;
    }
}
