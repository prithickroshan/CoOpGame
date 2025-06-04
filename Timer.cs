using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int timers = 200;
    public Text timer_visual;
    public Text winORLoose;
    public Text winORLoose1;
    public GameObject particle;
    bool Iswin=false;
    void Start()
    {
        StartCoroutine(timer());
        winORLoose.text = "";
        winORLoose1.text = "";
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Iswin)
        {
            particle.SetActive(true);
        }
    }
    IEnumerator timer()
    {
        while (true)
        {
          
            timers = timers - 1;
            timer_visual.text="TIMER:"+timers.ToString();
            yield return new WaitForSeconds(1);
            if(timers==0)
            {
                winORLoose.text = "you win";
                winORLoose1.text = "you loose";
                Iswin = true;
                break;
            }
        }
    }
}
