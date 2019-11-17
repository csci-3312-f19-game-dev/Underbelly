using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeScript : MonoBehaviour
{
    /*public static KnifeScript knisingleton;

    private void Awake()
    {
        if (knisingleton)
        {
            //singleton has been instantiate already.
            Destroy(gameObject);
        }
        else
        {
            //one has not been created yet:
            knisingleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "EvilHorsePuzzle") transform.position = new Vector3(0f, 0f);


        if (PlayerController.inventory == "Knife")
        {
            transform.position = new Vector3(786.4f, 641.3f);
        } else
        {
            if (SceneManager.GetActiveScene().name == "EvilHorsePuzzle") transform.position = new Vector3(728.91f, 616.51f, -1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.inventory = "Knife";

    }
}
