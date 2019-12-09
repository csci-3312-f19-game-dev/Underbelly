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

    // Start is called before the first frame update
    void Start()
    {
        play = true;
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
        if(SceneManager.GetActiveScene().name != "Spawn")
        {
            if (Input.GetKeyDown("space") && !play)
            {
                good.Play(0);
                bad.Pause();
                play = true;
                Debug.Log("good");
            }
            else if (Input.GetKeyDown("space") && play)
            {
                bad.Play(0);
                good.Pause();
                play = false;
                Debug.Log("bad");
            }
        }
    }
}
