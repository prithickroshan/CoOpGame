using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class rocket : MonoBehaviour
{
    NavMeshAgent na;
   GameObject target;
    public GameObject pannel;
    GameObject find;
    Image i;
    Color c;
    public static int counter = 0;
    void Start()
    {
        c.a = 0;
        target = GameObject.Find("Among Us Astronaut (1)");
        //find = GameObject.Find("Main Camera (1)");
        find = GameObject.Find("Panel");
        na= GetComponent<NavMeshAgent>();
        i=find.GetComponent<Image>();
        StartCoroutine(timer());
      
       
    }

    // Update is called once per frame
    void Update()
    {
        
        na.SetDestination(target.transform.position);
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(29);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.transform.tag=="player2"))
        {
            counter = 1;
            c = i.color;
            c.a = 1;
            Debug.Log("collision enter");
            Destroy(gameObject);
           
        }
    }
}
