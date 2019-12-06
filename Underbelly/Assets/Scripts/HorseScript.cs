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
        if(PlayerController.horseGone) hidden = true;
    }

    // Update is called once per frame
    void Update()
    {
        //hasCarrot = PlayerController.hasCarrot;
        //hasKnife = PlayerController.hasKnife;
        if (hidden || PlayerController.horseGone) transform.position = new Vector3(0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PlayerController.inventory == "Carrot")
        {
            hidden = true;
            PlayerController.goodBoyPoints += 1;
            PlayerController.horseGone = true;
        }
        if (collision.gameObject.CompareTag("Player") && PlayerController.inventory == "Knife")
        {
            //SceneManager.LoadScene("MainMenu");
            hidden = true;
            PlayerController.goodBoyPoints -= 1;
            PlayerController.horseGone = true;

        }
    }
}
