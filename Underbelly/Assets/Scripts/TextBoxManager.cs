﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public PlayerController player;

    public bool stopMovement;

    public TextAsset textFile;
    public string[] textLines;
    public Text theText;

    public bool isActive;

    public int currentLine;
    public int endAtLine;



    void Start()
    {
        //textBox = GameObject.FindGameObjectsWithTag("TextBox")[0];
        player = FindObjectOfType<PlayerController>();

        //Null check
        if (textFile != null) textLines = (textFile.text.Split('\n'));

        //Line count check
        if (endAtLine == 0) endAtLine = textLines.Length - 1;

        if (isActive) EnableTextBox();
        else DisableTextBox();
    }

    void Update()
    {
        //textBox = GameObject.FindGameObjectsWithTag("TextBox")[0];
        //Check whether or not the textbox should even be updated
        if (isActive) {
          EnableTextBox();
          Debug.Log("enabled");
        }
        else DisableTextBox();

        //Check when to update and hide text
        if (currentLine >= endAtLine)
        {
            //Debug.Log("DISABLING");
            DisableTextBox();
        }
        else theText.text = textLines[currentLine];

        //Scroll text
        if(Input.GetKeyDown(KeyCode.Return)) currentLine += 1;

    }

    public void EnableTextBox()
    {
        Debug.Log("settingVars");
        textBox.SetActive(true);
        Debug.Log(textBox.activeSelf);
        if (stopMovement) player.canMove = false;
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        player.canMove = true;
        isActive = false;
    }

    public void ReloadScript(TextAsset theText)
    {
        if (theText != null) {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
            Debug.Log("loaded text");
        }
    }
}
