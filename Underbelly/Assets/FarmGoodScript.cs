﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmGoodScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("FarmEvil");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player.transform.position = new Vector3(701.3f, 567.9f);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(750f, 593.1f);

            SceneManager.LoadScene("HorsePuzzle");


        }
    }
}
