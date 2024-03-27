using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// import packages
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{
    // referencing ink file
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public UnityEngine.UI.Button[] choiceBtns;
    public TMP_InputField inputField; // input field
    public AutoScroll autoScroll;
    public RectTransform contentRectTransform;
    public ScrollRect scrollView;

    private Story story;

    // stores convo history
    private StringBuilder convoHistory = new StringBuilder();

    // stores if choiceBtn was clicked
    private bool choiceButtonPressed = false;


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

    // adjusting content size
    private void adjustContentSize()
    {
        // getting prefered height of content txt box
        float contentHeight = textBox.preferredHeight;

        // update rectTransform to fit
        Vector2 sizeDelta = contentRectTransform.sizeDelta;
        sizeDelta.y = contentHeight;
        contentRectTransform.sizeDelta = sizeDelta;
    }

    // continueStory func
    private void continueStory()
    {
        // checking if story can cont.
        while (story.canContinue)
        {
            textBox.gameObject.SetActive(true); // visibility = true
            string currentLine = story.Continue();

            // when tag is detected, change text colour to dark blue
            List<string> tags = story.currentTags;
            if (tags.Count > 0)
            {
                currentLine = "<color=#00008b>" + currentLine + "</color>";
            }

            convoHistory.AppendLine(currentLine); // Append the current line to the convoHistory
            textBox.text = convoHistory.ToString(); // Update the text box with the entire convoHistory

            // scroll to bottom
            Canvas.ForceUpdateCanvases();
            scrollView.verticalNormalizedPosition = 0f;

            showChoices();
        }
        if (!story.canContinue)
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
        // broken logic here but makes program work... fix later
        textBox.gameObject.SetActive(true);
    }
}

// test test
