using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotScript : MonoBehaviour
{
    public bool hidden = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hidden || PlayerController.carrotHidden)
        {
            this.transform.position = new Vector3(0,0,0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.hidden = true;
        PlayerController.carrotHidden = true;
        PlayerController.knifeHidden = false;
        PlayerController.inventory = "Carrot";
    }

}
