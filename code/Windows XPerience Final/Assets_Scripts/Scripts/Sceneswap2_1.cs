using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneswap2_1 : MonoBehaviour
{
    bool  checkassignment;
    bool changed;
    public bool dinosaur_roar = false;
    // Start is called before the first frame update
    void Start()
    {
       changed = true;
    }

    // Update is called once per frame
    void Update()
    {
        checkassignment = GameObject.Find("chrome").GetComponent<Sceneswap2>().assignmentcollide;
        
        if (checkassignment==true && changed ==true)
        {
            //Debug.Log("Go to chrome!!!");
            gameObject.transform.position = new Vector3(75.5263f, 0.47f, 46.372f);
            changed = false;
            dinosaur_roar = true;
        }

        
    }
}
