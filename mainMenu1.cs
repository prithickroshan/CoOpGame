using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu1 : MonoBehaviour
{
    public Button btn;
    public GameObject btns;
    public Animator animator;
    public GameObject btn1;
    public GameObject btn2;
    public Button actualBtn;
    public Button actualBtn1;
    void Start()
    {
        btn.onClick.AddListener(Play);
        animator.SetBool("cam_trans", !true);
        btn1.SetActive(false);
        btn2.SetActive(false);
        actualBtn.onClick.AddListener(GameStart1);
        actualBtn1.onClick.AddListener(GameStart2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {
        Debug.Log("game played");
        btns.SetActive(false);
        animator.SetBool("cam_trans", true);
        StartCoroutine(timer());
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1.5f);
        btn1.SetActive(!false);
        btn2.SetActive(!false);

    }
    void GameStart1()
    {
        SceneManager.LoadScene(1);
    }
    void GameStart2() {
        SceneManager.LoadScene(3);
    }
}
