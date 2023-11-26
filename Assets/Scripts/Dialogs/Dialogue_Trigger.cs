using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_Dialogue : MonoBehaviour
{
    public Message[] messages;
    public Author[] authors;

    public void Start_Conversation()
    {
        gameObject.SetActive(false);
        FindObjectOfType<Dialogue_Manger>().OpenDialogue(messages, authors);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public int actorID;
}

[System.Serializable]
public class Author
{
    public string name;
    public Sprite sprite;
}

