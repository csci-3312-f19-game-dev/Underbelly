using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
    public TextAsset theText;
    public string item;
    public string inventoryItem;

    public int startLine;
    public int endLine;

    public bool destroyWhenActivated;

    public PlayerController player;

    public TextBoxManager textManager;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        textManager = FindObjectOfType<TextBoxManager>();
    }

    void Update()
    {
        inventoryItem = player.getItem();
    }

    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.name == "player" && inventoryItem == item)
        {
            textManager.ReloadScript(theText);
            textManager.currentLine = startLine;
            textManager.endAtLine = endLine;
        }

        if (destroyWhenActivated) Destroy(gameObject);
    }
}
