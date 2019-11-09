using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotScript : MonoBehaviour
{
    public static bool hasCarrot;
    public bool hidden = false;
    // Start is called before the first frame update
    void Start()
    {
        hasCarrot = false;
    }

    // Update is called once per frame
    void Update()
    {
        hasCarrot = PlayerController.hasCarrot;
        if (hidden || PlayerController.hasCarrot)
        {
            this.transform.position = new Vector3(0,0,0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.hidden = true;
        PlayerController.hasCarrot = true;
        hasCarrot = true;
    }

}
