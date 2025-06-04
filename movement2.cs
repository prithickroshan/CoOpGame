    using System.Collections;
    using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;
    using UnityEngine.UI;

    public class movement2 : MonoBehaviour
    {
         Rigidbody body;
        Animator animator;
        public ParticleSystem ps;
        public GameObject teleporter;
        GameObject clone1;
       public static int checkpoint = 0;
        int count = 0;
        public GameObject checkpoint1;
        public Text points;
        int points_int = 0;
        public GameObject checkpoint2;
        public GameObject checkpoint3;
        int counter = 0;
        public ParticleSystem explosion;
    public Text p1;
    public Text p2;
    public GameObject particle;
    public GameObject pannel;
        void Start()
        {
            body= GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
        particle.SetActive(false);
        
        }

        // Update is called once per frame
        void Update()
        {
            float input = Input.GetAxisRaw("Horizontal");
            float input2 = Input.GetAxisRaw("Vertical");
            if(input<0)
            {
                animator.SetBool("run",true);
                body.velocity=new Vector3(transform.forward.x,0,transform.forward.z)*5;
                ps.Play();
            }
            if(input==0)
            {

                animator.SetBool("run",false);
                body.velocity = new Vector3(transform.forward.x, 0, transform.forward.z)*0;
                ps.Stop();
            }
            if (input2 == 1)
            {
                transform.Rotate(0, 1, 0);
            }
            if(input2==-1)
            {
                transform.Rotate(0, -1, 0);
            }
            if(Input.GetKeyDown(KeyCode.Joystick1Button0)&&count!=1)
            {
                Instantiate(teleporter,transform.position,Quaternion.identity);
                count += 1;
            
            }
            if(Input.GetKeyDown(KeyCode.Joystick1Button1))
            {
                clone1 = GameObject.Find("Cube(Clone)");
                transform.position= clone1.transform.position;
            }
            if(Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                clone1= GameObject.Find("Cube(Clone)");
                Destroy(clone1);
                count = 0;
            }
            if(checkpoint==3)
        {
            p1.text = "YOU LOOSE";
            p2.text = "YOU WIN";
            particle.SetActive(true);
        }

        
        
        }
        private void OnTriggerEnter(Collider other)
        {
            counter = 3;
            if (other.tag=="checkpoint")
            {
                checkpoint+= 1;
                Debug.Log("touched");
            
               StartCoroutine(checkPointDestroyer());
            
            }
            if(other.tag=="checkpoint2")
            {
                checkpoint+= 1;
                Debug.Log("touched");

                StartCoroutine(checkPointDestroyer());
            }
            if (other.tag == "checkpoint3")
            {
                checkpoint+=1;
                Debug.Log("touched");

                StartCoroutine(checkPointDestroyer());
            }
            if(other.tag=="landmine")
            {
            pannel.SetActive(true);
                explosion.Play();
            }
        }
     
        IEnumerator checkPointDestroyer()
        {
       
        
                yield return new WaitForSeconds(3);
                if (checkpoint == 1)
                {
                    Destroy(checkpoint1);
                    points_int += 1;
                    points.text = "CAPTURE POINT:" + points_int.ToString();
                
                }
                if (checkpoint == 2)
                {
                    Destroy(checkpoint2);
                    points_int += 1;
                    points.text = "CAPTURE POINT:" + points_int.ToString();
                
                }
                if (checkpoint == 3)
                {
                    Destroy(checkpoint3);
                    points_int += 1;
                    points.text = "CAPTURE POINT:" + points_int.ToString();
                
                }
        
        

        }
    }
