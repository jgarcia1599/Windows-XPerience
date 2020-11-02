using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswap : MonoBehaviour
{
    // Start is called before the first frame update
    public bool changed;
    public float initz;
    public float currentz;
    GameObject monitor = GameObject.Find("monitor");
    //public Scene currentscene;
    void Start()
    {
        //currentscene = SceneManager.GetActiveScene();
        initz = GameObject.Find("monitor").transform.position.z;
        changed = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentz= GameObject.Find("monitor").transform.position.z;
        //print("currentz: "+currentz);
        //print("initz:"+  initz);
        if (changed==true)
        {
            if (initz-currentz > 0.02f || initz - currentz < -0.02f)
            {
                Destroy(monitor);
                gameObject.transform.position=new Vector3(-0.032f, -0.01f,-0.19f);//Position to scene 2
                //SceneManager.LoadSceneAsync("Scene2");
                //SceneManager.UnloadSceneAsync(currentscene);
                //Application.LoadLevel(2);
                changed = false;
            }



        }

    }
}
