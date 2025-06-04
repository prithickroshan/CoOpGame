using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class wayPointCalculator : MonoBehaviour
{
   NavMeshAgent agent;
    public GameObject checkPoint1;
    public GameObject checkPoint2;
    public GameObject checkPoint3;
    public GameObject p2;
    bool resume=false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(resume)
        {
            if (Vector3.Distance(transform.position, checkPoint1.transform.position) != 1 && movement2.checkpoint == 0)
            {
                agent.SetDestination(checkPoint1.transform.position);
            }
            if (movement2.checkpoint == 1)
            {

                if (Vector3.Distance(transform.position, checkPoint2.transform.position) != 1)
                {
                    agent.SetDestination(checkPoint3.transform.position);
                }
            }
        }
       
        Debug.Log(movement2.checkpoint);
         if(Vector3.Distance(transform.position,p2.transform.position)>=10)
        {
            resume = false;
            agent.isStopped = true;
        }
        if (Vector3.Distance(transform.position, p2.transform.position) <= 10)
        {
            resume = true;
            agent.isStopped = !true;
        }


    }
}
