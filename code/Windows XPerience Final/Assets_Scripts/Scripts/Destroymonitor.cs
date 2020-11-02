using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroymonitor : MonoBehaviour
{
    public bool changed;
    public float initz;
    public float currentz;
    // Start is called before the first frame update
    void Start()
    {
        initz = gameObject.transform.position.z;
        changed = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentz = gameObject.transform.position.z;
        if (changed == true)
        {
            if (initz - currentz > 0.02f || initz - currentz < -0.02f)
            {
                Destroy(gameObject);
                changed = false;

            }
        }
    }
}
