using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue_Manger : MonoBehaviour
{
    public Image avatar;
    public TextMeshProUGUI name;
    public TextMeshProUGUI text;
    public RectTransform background;

    Message[] curr_messages;
    Author[] curr_authors;
    int active_message = 0;
    bool active;

    public void OpenDialogue(Message[] messages, Author[] authors)
    {
        curr_messages = messages;
        curr_authors = authors;
        active_message = 0;
        active = true;

        Debug.Log("Mess + auth + " +  curr_messages.Length);
        Debug.Log(curr_messages[0].text);
        Display_Message();
    }

    public void Display_Message()
    {
        Message msg_to_show = curr_messages[active_message];
        text.text = msg_to_show.text;
        name.text = curr_authors[msg_to_show.actorID].name;
        avatar.sprite = curr_authors[msg_to_show.actorID].sprite;
    }

    public void Next_Message()
    {
        active_message++;
        if (active_message >= curr_messages.Length)
        {
            Debug.Log("END");
            active = false;
        }
        else
        {
            Display_Message();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && active)
        {
            Next_Message();
        }
    }
}
