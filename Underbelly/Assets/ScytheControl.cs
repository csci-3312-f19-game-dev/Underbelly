using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScytheControl : MonoBehaviour
{
    /*public static ScytheControl scysingleton;

    private void Awake()
    {
        if (scysingleton)
        {
            //singleton has been instantiate already.
            Destroy(gameObject);
        }
        else
        {
            //one has not been created yet:
            scysingleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        if(PlayerController.inventory == "Scythe")
        {
            transform.position = new Vector3(0f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Barn") transform.position = new Vector3(0f, 0f);
        if (PlayerController.inventory == "Scythe")
        {
            transform.position = new Vector3(786.4f, 641.3f);
        } else
        {
            if (SceneManager.GetActiveScene().name == "Barn") transform.position = new Vector3(678f, 573f, -1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.inventory = "Scythe";
            
        }
    }
}
