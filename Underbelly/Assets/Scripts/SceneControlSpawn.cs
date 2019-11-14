using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControlSpawn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Player"));
        if (GameObject.FindGameObjectWithTag("Player").transform.position.x < 638.8)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(640f, transform.position.y);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(640.5f, 593.4f);
            SceneManager.LoadScene("HorsePuzzle");
        }
    }


}
