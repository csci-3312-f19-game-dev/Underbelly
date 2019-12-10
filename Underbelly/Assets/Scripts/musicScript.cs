using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicScript : MonoBehaviour
{
    public static musicScript singleton;
    public AudioSource good;
    public AudioSource bad;
    public bool play;

    //public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        play = true;
        //textBox = GameObject.FindGameObjectsWithTag("TextBox")[0];
        //good = GetComponent<AudioSource>();
        //bad = GetComponent<AudioSource>();
        //good.Play();
        //bad.Play();
        //good.Pause();
        //bad.Pause();
    }

    private void Awake()
    {
        if (singleton)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //textBox = GameObject.FindGameObjectsWithTag("TextBox")[0];

        if (SceneManager.GetActiveScene().name != "Spawn")
        {
            if (Input.GetKeyDown("space") && !play)
            {
                good.Play(0);
                bad.Pause();
                play = true;
                Debug.Log("good");
                //textBox.SetActive(false);
            }
            else if (Input.GetKeyDown("space") && play)
            {
                bad.Play(0);
                good.Pause();
                play = false;
                Debug.Log("bad");
                //textBox.SetActive(false);
            }
        }
    }
}
