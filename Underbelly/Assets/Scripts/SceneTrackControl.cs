using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrackControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Player"));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("EvilHorsePuzzle");
            //SceneManager.MoveGameObjectToScene(gameObject.GetComponent(player), "EvilHorsePuzzle");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //GameObject.FindGameObjectWithTag("Horse").transform.position = new Vector3(0f,0f);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(760f, 568f);
            SceneManager.LoadScene("Spawn");
        }
    }

    
}
