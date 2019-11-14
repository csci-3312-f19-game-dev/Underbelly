using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDisappear : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //GameObject.FindGameObjectWithTag("Player");
            if (PlayerController.inventory == "Knife")
            {
                transform.position = new Vector3(0f, 0f);
                PlayerController.rocksaredead = true;
            }
        }
    }
}
