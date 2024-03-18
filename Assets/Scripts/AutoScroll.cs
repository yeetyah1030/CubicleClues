using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoScroll : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform contentRectTransform;

    public void ScrollToBottom()
    {
        // calc normalized pos
        float normalizedPosition = 0;

        if(scrollRect.verticalNormalizedPosition == 1)
        {
            // if it's at bottom, keep it there
            normalizedPosition = 1;
        }
        else if (contentRectTransform.rect.height > scrollRect.viewport.rect.height)
        {
            // if content is taller than viewport, scroll to bottom
            normalizedPosition = 0;
        }
        else
        {
            // if content is shorter than or equal to viewport, keep it at the top
            normalizedPosition = 1;
        }
        // setting verticalNormalizedPostion based on ^
        scrollRect.verticalNormalizedPosition = normalizedPosition;
    }
}
