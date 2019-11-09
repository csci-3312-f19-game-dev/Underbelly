using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HorseScript : MonoBehaviour
{
    //public static bool hasCarrot;
    //public static bool hasKnife;
    public static int goodBoyPoints;
    public bool hidden;
    // Start is called before the first frame update
    void Start()
    {
        hidden = false;
    }

    // Update is called once per frame
    void Update()
    {
        //hasCarrot = PlayerController.hasCarrot;
        //hasKnife = PlayerController.hasKnife;
        if (hidden) transform.position = new Vector3(0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PlayerController.hasCarrot == true)
        {
            hidden = true;
            goodBoyPoints += 1;
        }
        if (collision.gameObject.CompareTag("Player") && PlayerController.hasKnife == true)
        {
            //SceneManager.LoadScene("MainMenu");
            hidden = true;
            goodBoyPoints -= 1;
        }
    }
}
