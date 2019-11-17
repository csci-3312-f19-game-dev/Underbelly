using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControlEvilHorse : MonoBehaviour
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
            SceneManager.LoadScene("HorsePuzzle");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(702f, 569.3f);

            SceneManager.LoadScene("InsideHouseEvil");
            
        }
    }

}
