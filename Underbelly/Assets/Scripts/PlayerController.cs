using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static bool rocksaredead;
    public static bool fieldsGone;
    public static bool hasGold;
    public static bool townIsEvil;
    public static bool endGame;

    public static AudioSource good;
    float gSlide;
    public static AudioSource bad;
    float bSlide;

    public float playerVelocity = 50.0f;
    public float hmovement = 0f;
    public float vmovement = 0f;
    private Rigidbody2D rigidBody2D;
    public bool HasBeenToHorsePuzzle;
    public bool comingFromSpawn;
    public bool FirstFrame;

    public static bool horseGone;

    public static int goodBoyPoints;


    public static string inventory;

    public Animator animator;

    public bool canMove;

    Vector3 position;

    public static PlayerController singleton;

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
            //good.Play();
            //bad.Play();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //gSlide = 1.0f;
        //bSlide = 0.0f;
        good = GetComponent<AudioSource>();
        bad = GetComponent<AudioSource>();
        //good.Play();
        //bad.Play();

        endGame = false;
        rocksaredead = false;
        fieldsGone = false;
        horseGone = false;
        hasGold = false;
        townIsEvil = false;

        position = transform.position;

        inventory = "";

        rigidBody2D = GetComponent<Rigidbody2D>();
        HasBeenToHorsePuzzle = false;
        comingFromSpawn = true;
        FirstFrame = false;
        goodBoyPoints = 0;
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("space") && gSlide == 1.0f)
        {
            gSlide = 0.0f;
            bSlide = 1.0f;
        }
        else if(Input.GetKeyDown("space") && gSlide == 0.0f)
        {
            gSlide = 1.0f;
            bSlide = 0.0f;
        }*/

        if (!canMove) {
            rigidBody2D.velocity = new Vector2(0.0f, 0.0f);
            return;
        }

        if(SceneManager.GetActiveScene().name == "HorsePuzzle" && comingFromSpawn)
        {
            HasBeenToHorsePuzzle = true;
            comingFromSpawn = false;
            transform.position = new Vector3(652.5f, 593.4f);
        }

        //if (SceneManager.GetActiveScene().name == "InsideHouseEvil" && FirstFrame)
        //{
        //    transform.position = new Vector3(701.3f, 567.9f);
        //    FirstFrame = false;
        //}

        //goodBoyPoints = HorseScript.goodBoyPoints; //+later goodBoyPoints in other puzzles


        hmovement = Input.GetAxis("Horizontal");
        vmovement = Input.GetAxis("Vertical");
        rigidBody2D.velocity = new Vector2(hmovement * playerVelocity, vmovement * playerVelocity);

        animator.SetFloat("Speedy", vmovement);
        animator.SetFloat("Speedx", hmovement);
        //we are getting input from left/right arrow keys using the input axis system:

        //position.x += Input.GetAxis("Horizontal") * playerVelocity * Time.deltaTime;
            //"clamp" limits the value of a variable to a min or a max value:
            //position.x = Mathf.Clamp(position.x, -100f, 100f);



        //position.y += Input.GetAxis("Vertical") * playerVelocity * Time.deltaTime;
            //max speed of player will be 0.8 in the forward direction:
            //position.y = Mathf.Clamp(position.y, -100f, 100f);

         //transform.position = position;
         if(endGame)
        {
            if (goodBoyPoints >= -1)
            {
                SceneManager.LoadScene("GoodEnd");
            } else
            {
                SceneManager.LoadScene("BadEnd");
            }
        }


    }

    public string getItem() {
        return inventory;
    }


}
