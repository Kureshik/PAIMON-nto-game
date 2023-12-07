using MEET_AND_TALK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Trigger : MonoBehaviour
{
    [SerializeField] private DialogueContainerSO dialogue;
    [SerializeField] private DialogueManager dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        dialogueManager.SetupDialogue(dialogue);
        dialogueManager.StartDialogue(dialogue);
    }
}
