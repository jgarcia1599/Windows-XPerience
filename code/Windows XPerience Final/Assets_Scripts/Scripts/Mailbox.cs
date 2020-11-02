using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mailbox : MonoBehaviour
{
    GameObject all = GameObject.Find("AllObjects");
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Assignment Variant(Clone)")
        {
            //Debug.Log("You win!!!!!");
            string game = SceneManager.GetActiveScene().name;
            //Destroy(all);
            DestroyAllGameObjects();
            SceneManager.UnloadSceneAsync(game);
            SceneManager.LoadScene(game);

        }

    }
    public void DestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < GameObjects.Length; i++)
        {
            Destroy(GameObjects[i]);
        }
    }
}
