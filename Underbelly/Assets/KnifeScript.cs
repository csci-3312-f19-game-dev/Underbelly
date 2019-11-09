using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public static bool hasKnife;
    public static bool hasCarrot;
    public bool hidden = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        hasKnife = PlayerController.hasKnife;
        hasCarrot = PlayerController.hasCarrot;
        if (hidden || PlayerController.hasKnife)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.hidden = true;
        hasKnife = true;
        PlayerController.hasKnife = true;
        hasCarrot = false;
    }
}
