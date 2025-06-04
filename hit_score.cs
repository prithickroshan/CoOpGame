using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hit_score : MonoBehaviour
{
    public Text score;
    static int a;
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        a++;
        score.text = a.ToString();


    }
}
