using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// import packages
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System;
using System.Reflection;

public class DialogueManager : MonoBehaviour
{
    // referencing ink file
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public Button[] choiceBtns;
    public TMP_InputField inputField; // input field
    public TextMeshProUGUI errorBox;

    private int choiceIdx;
    private bool storyStarted = false;

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
        if (storyStarted == false)
        {
            startStory();
        }
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
        if (story.canContinue && compareText(choiceIdx)==true)
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
        choiceIdx = choiceIndex;
        continueStory();
    }

    // when dialogue is finished
    private void finishDialogue()
    {
        textBox.gameObject.SetActive(false);
    }

    private bool compareText(int choiceIdx)
    {
        if (inputField.GetComponent<TMP_InputField>().text == choiceBtns[choiceIdx].GetComponentInChildren<TextMeshProUGUI>().text && Input.GetKeyDown(KeyCode.Return))
        {
            inputField.GetComponent<TMP_InputField>().text = null;
            choiceIdx = 999;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            errorBox.GetComponent<TextMeshProUGUI>().text = "Your message doesn't match the text to type... Try again.";
            return false;
        }
        else
        {
            return false;
        }
    }

    private void startStory()
    {
        if (storyStarted == false)
        {
            if (story.canContinue)
            {
                textBox.gameObject.SetActive(true); // visibility = true
                                                    //textBox.text = "\n" + story.Continue(); // pulls next line of dialogue and discards after
                string currentLine = story.Continue();
                convoHistory.AppendLine(currentLine); // Append the current line to the convoHistory
                textBox.text = convoHistory.ToString(); // Update the text box with the entire convoHistory
                showChoices();
            }
            storyStarted = true;
        }
    }
}
