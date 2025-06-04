using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Ray r;
    RaycastHit hit;
    public LayerMask mask;
    public LayerMask mask2;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.forward;
        r = new Ray(transform.position,transform.forward);
        if(Physics.Raycast(r,out hit,10,mask))
        {
            anim.SetBool("victory", true);
           // anim.SetBool("scar", !true);
        }
        if(Physics.Raycast(r, out hit, 10, mask2))
        {
            //anim.SetBool("victory", !true);
            anim.SetBool("scar", true);
        }
        
        if (Physics.Raycast(r, out hit, 10, mask)==false&& Physics.Raycast(r, out hit, 10, mask2)==false)
        {
            anim.Rebind();
        }
       
        
    }
}
