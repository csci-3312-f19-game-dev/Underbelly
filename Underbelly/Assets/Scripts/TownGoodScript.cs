using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownGoodScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("FieldComp").transform.position = new Vector3(0f, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("TownEvil");
        }
        if(PlayerController.townIsEvil)
        {
            GameObject.FindGameObjectWithTag("FieldComp").transform.position = new Vector3(720f, 593.4f);
            GameObject.FindGameObjectWithTag("GameController").transform.position = new Vector3(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player.transform.position = new Vector3(701.3f, 567.9f);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(750f, 593.1f);

            SceneManager.LoadScene("FarmGood");


        }
    }
}
