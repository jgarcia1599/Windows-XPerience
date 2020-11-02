using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarget : MonoBehaviour
{
    public GameObject target;//the target dinosaur will go to are going too

    public float speed;//the speed of enemiess
    public float jumpingdistance;//distance between object and target
    public bool jumped = false;
    public bool attacked = false;
    public float jumping_height;
    public int hit = 0;
    public int lives=5;
    public GameObject mailbox;  
    void Start()
    {
        mailbox = GameObject.Find("GmailMailbox");
        mailbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bool roar = GameObject.Find("Player").GetComponent<Sceneswap2_1>().dinosaur_roar;
        if (hit==lives)
        {
            mailbox.SetActive(true);
            Destroy(gameObject);
        }
        if(roar==true)
        {
            //gameObject.GetComponent<AudioSource>().enabled = true;
        }
        gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        //Debug.Log("Distance between Player and dino: " + Vector3.Distance(transform.position, target.transform.position));
        if(Vector3.Distance(transform.position,target.transform.position)<=jumpingdistance && jumped == false)
        {
            //Debug.Log("Jump!!!");
            jumped = true;
            StartCoroutine("delay");
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumping_height, 0), ForceMode.Impulse);


        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name=="cactus"&& attacked==false)
        {
            attacked = true;
            hit += 1;
            StartCoroutine("delay1");            
            //Debug.Log("Dino is in pain aaaaaaah;counter: "+hit);
        }
        
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
        jumped = false;
    }
    IEnumerator delay1()
    {
        yield return new WaitForSeconds(2);
        attacked = false;
    }
}

