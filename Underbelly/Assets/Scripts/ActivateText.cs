using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
    public TextAsset theText;
    public string item;

    public int startLine;
    public int endLine;

    public bool destroyWhenActivated;

    public TextBoxManager textManager;

    void Start()
    {
        textManager = FindObjectOfType<TextBoxManager>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.name == "player")
        {
            textManager.ReloadScript(theText);
            textManager.currentLine = startLine;
            textManager.endAtLine = endLine;
        }

        if (destroyWhenActivated) Destroy(gameObject);
    }
}
