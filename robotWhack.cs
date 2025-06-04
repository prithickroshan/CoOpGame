using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotWhack : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 273.100006f, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 4.89999819f, 0));
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 76.4999847f, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 175.730011f, 0));
        }
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("hit", true);
            StartCoroutine(beat());
        }
        

    }
    IEnumerator beat()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("hit", !true);
    }
}
