using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmGoodScript : MonoBehaviour
{
    public GameObject[] fields;
    private int fieldCount = 0;
    // Start is called before the first frame update
    void Start()
    {
 
        fields = GameObject.FindGameObjectsWithTag("FieldComp");

        if (PlayerController.fieldsGone)
        {
            foreach (GameObject field in fields)
            {
                field.transform.position = new Vector3(0f, 0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("FarmEvil");
            PlayerController.bad.Play();
        }
        fields = GameObject.FindGameObjectsWithTag("FieldComp");

        foreach (GameObject field in fields)
        {
            if ((field.transform.position.x > -.01f) && (field.transform.position.x < .01f))
            {
                fieldCount += 1;
            }
        }  
        if (fieldCount == 16)
        {
            PlayerController.hasGold = true;
            PlayerController.fieldsGone = true;
            
        }
        fieldCount = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player.transform.position = new Vector3(701.3f, 567.9f);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(760f, 593.1f);

            SceneManager.LoadScene("HorsePuzzle");


        }
    }
}
