    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculateDirection : MonoBehaviour
{
    int cp1;
    int cp2;
    int cp3;
    int counter = 0;
    public Text display;
    public GameObject checkPoint1;
    public GameObject checkPoint2;
    public GameObject checkPoint3;
    public GameObject player;
    public Text Player1WinORLoose;
    public GameObject WinORLoose;
    void Start()
    {
        WinORLoose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            cp1 = (int)Vector3.Distance(player.transform.position, checkPoint1.transform.position);
            display.text = cp1.ToString();
            if (cp1 == 0)
            {
                Debug.Log("reached");
                counter = 1;
            }
            if(counter==1)
            {
                cp2 = (int)Vector3.Distance(player.transform.position, checkPoint2.transform.position);
                display.text = cp2.ToString();
               if(cp2 == 0)
                {
                    counter = 2;
                }
            }
            if(counter==2)
            {
                cp3 = (int)Vector3.Distance(player.transform.position, checkPoint3.transform.position);
                display.text=cp3.ToString();
                if(cp3 == 0)
                {
                    WinORLoose.SetActive(true);
                }
            }
        }
        catch
        {

            Debug.Log("code no error");
        }
        
    }
}
