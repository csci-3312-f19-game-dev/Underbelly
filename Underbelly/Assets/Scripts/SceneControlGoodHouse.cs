using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControlGoodHouse : MonoBehaviour
{
    //GameObject player = GameObject.FindGameObjectWithTag("Player");

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(701.3f, 567.9f);

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("InsideHouseEvil");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player.transform.position = new Vector3(701.3f, 567.9f);
            SceneManager.LoadScene("HorsePuzzle");
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(657.2f, 613.9f);


        }
    }
}
