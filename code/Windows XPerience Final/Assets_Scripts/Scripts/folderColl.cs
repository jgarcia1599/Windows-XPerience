using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folderColl : MonoBehaviour
{
    public GameObject target;
    public int counter = 0;
    public GameObject proj;
    public GameObject assignment;
    public bool assignmentappeared = false;
    public float speed = 4;
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        random = RandomNumber(1, 9);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (counter <= 10)
        {
            //counter += 1;
            if (collision.gameObject.name == target.name)
            {
                if (counter == random && assignmentappeared == false)
                {
                    Debug.Log("Assignment!!!");
                    Instantiate(assignment, transform.position, transform.rotation);
                    counter += 1;
                    assignmentappeared = true;
                }
                else
                {
                    //Debug.Log("Folders Appear!!!");
                    Instantiate(proj, transform.position, transform.rotation);
                    counter += 1;
                }

            }

        }
    }
    public int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
