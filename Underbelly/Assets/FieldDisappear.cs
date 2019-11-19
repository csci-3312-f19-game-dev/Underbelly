using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldDisappear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            if (PlayerController.inventory == "Scythe")
            {
                transform.position = new Vector3(0f, 0f);
            }
        }
    }
}
