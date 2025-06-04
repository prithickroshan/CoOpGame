using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuSelection : MonoBehaviour
{
    public int counter = 0;
    public GameObject g1;
    public GameObject g2;
    public AudioSource au1;
    public AudioClip ac1;
    public AudioSource au2;
    public AudioClip ac2;
    public Text text;
    public GameObject hide;
    public int score = 5;
    void Start()
    {
        hide.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            counter += 1;
            g1.SetActive(true);
            Debug.Log("buttonPressed");
            au1.clip = ac1;
            au1.Play();
        }    
        if(Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            au2.clip = ac2;
            au2.Play();
            counter += 1;
            g2.SetActive(true);
           
        }
        if(counter==2)
        {
            hide.SetActive(true);
            StartCoroutine(timer());
            counter = 0;
        }

    }
    IEnumerator timer()
    {

        
            text.text = "5";
            yield return new WaitForSeconds(1);
            text.text = "4";
            yield return new WaitForSeconds(1);
            text.text = "3";
            yield return new WaitForSeconds(1);
            text.text = "2";
            yield return new WaitForSeconds(1);
            text.text = "1";
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(2);
             
        
        
     
    }
}
