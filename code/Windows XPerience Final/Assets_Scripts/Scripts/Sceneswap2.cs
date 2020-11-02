using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswap2 : MonoBehaviour
{
    public bool assignmentcollide = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Assignment Variant(Clone)")
        {
            assignmentcollide =true;
        }
        
    }



}
