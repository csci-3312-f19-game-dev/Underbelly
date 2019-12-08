using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueControl : MonoBehaviour
{
    public static DialogueControl instance = null;

    void Start()
    {
      if (instance == null) instance = this;
      else if (instance != this) Destroy(gameObject);

      DontDestroyOnLoad(transform.gameObject);
    }
}
