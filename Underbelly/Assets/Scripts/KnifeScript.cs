using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public bool hidden = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        if (hidden || PlayerController.knifeHidden)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.inventory = "Knife";
        PlayerController.carrotHidden = false;
        PlayerController.knifeHidden = true;
        this.hidden = true;
    }
}
