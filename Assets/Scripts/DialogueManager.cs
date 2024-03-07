using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// import packages
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System;

public class DialogueManager : MonoBehaviour
{
    // referencing ink file
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public Button[] choiceBtns;

    private Story story;

    // stores convo history
    private StringBuilder convoHistory = new StringBuilder();


    void Start()
    {
        // importing ink file as a new story
        story = new Story(inkFile.text);
        continueStory();
        showChoices();

    }


    void Update()
    {
        // checks if user presses enter key
        if (Input.GetButtonDown("Submit"))
        {
            continueStory();
        }
    }

    // continueStory func
    private void continueStory()
    {
        // checking if story can cont.
        if (story.canContinue)
        {
            textBox.gameObject.SetActive(true); // visibility = true
            //textBox.text = "\n" + story.Continue(); // pulls next line of dialogue and discards after
            string currentLine = story.Continue();
            convoHistory.AppendLine(currentLine); // Append the current line to the convoHistory
            textBox.text = convoHistory.ToString(); // Update the text box with the entire convoHistory
            showChoices();
        }
        else
        {
            finishDialogue();
        }
    }

    private void showChoices()
    {
        // populate list with current choices
        List<Choice> choices = story.currentChoices;
        int index = 0;
        foreach (Choice c in choices)
        {
            // pulling reponse text and putting it into button
            choiceBtns[index].GetComponentInChildren<TextMeshProUGUI>().text = c.text;
            choiceBtns[index].gameObject.SetActive(true);
            index++;
        }

        for (int i = index; i < 3; i++)
        {
            choiceBtns[i].gameObject.SetActive(false);
        }

    }

    public void setDecision(int choiceIndex)
    {
        story.ChooseChoiceIndex(choiceIndex);
        continueStory();
    }

    // when dialogue is finished
    private void finishDialogue()
    {
        textBox.gameObject.SetActive(false);
    }
}
