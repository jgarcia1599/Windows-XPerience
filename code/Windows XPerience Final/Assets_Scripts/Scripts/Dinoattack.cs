using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dinoattack : MonoBehaviour
{
    GameObject all = GameObject.Find("AllObjects");
    public int playerattacked;
    public int lives;
    private bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerattacked>=lives && dead == false)
        {
            string game = SceneManager.GetActiveScene().name;
            dead = true;
            Debug.Log("Start Again");
            //Destroy(all);
            DestroyAllGameObjects();
            SceneManager.UnloadSceneAsync(game);
            SceneManager.LoadScene(game);
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision detected!");
        //Debug.Log("lives = :"+lives);
        //Debug.Log("Player attacked: " + playerattacked);
        if (collision.gameObject.name == "dinofinal")
        {
            playerattacked += 1;
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
