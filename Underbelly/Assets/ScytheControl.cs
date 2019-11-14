using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheControl : MonoBehaviour
{
    public static ScytheControl singleton;

    private void Awake()
    {
        if (singleton)
        {
            //singleton has been instantiate already.
            Destroy(gameObject);
        }
        else
        {
            //one has not been created yet:
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.inventory = "Scythe";
            transform.position = new Vector3(0f, 0f);
            
        }
    }
}
