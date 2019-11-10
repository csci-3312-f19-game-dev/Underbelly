using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour
{

    public GameObject textBox;
    public Text fullText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if (textFile != null)
        {
          textLines = (textFile.text.Split('\n'));
        }
    }
}
