using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwineControl : MonoBehaviour
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
        if (PlayerController.inventory == "Twine")
        {
            transform.position = new Vector3(0f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().name != "TwineHouse") transform.position = new Vector3(0f, 0f);
        if (PlayerController.inventory == "Twine")
        {
            transform.position = new Vector3(786.4f, 641.3f);
        }
        else
        {
            transform.position = new Vector3(0f, 0f, -1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.inventory = "Twine";

        }
    }
}
