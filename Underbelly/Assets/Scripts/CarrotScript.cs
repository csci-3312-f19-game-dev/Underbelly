using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarrotScript : MonoBehaviour
{
    /*public static CarrotScript carsingleton;

    private void Awake()
    {
        if (carsingleton)
        {
            //singleton has been instantiate already.
            Destroy(gameObject);
        }
        else
        {
            //one has not been created yet:
            carsingleton = this;
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
        if (SceneManager.GetActiveScene().name != "InsideHouseGood") transform.position = new Vector3(0f, 0f);


        if (PlayerController.inventory == "Carrot")
        {
            transform.position = new Vector3(786.4f, 641.3f);
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "InsideHouseGood") transform.position = new Vector3(720.16f, 609.79f, -1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.inventory = "Carrot";

    }
}
