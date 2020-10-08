using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContextualMessageController : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private TMP_Text messageText;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        messageText = GetComponent<TMP_Text>();

        //invisible
        canvasGroup.alpha = 0;

        StartCoroutine(ShowMessage("TESTING", 2));
    }

    private IEnumerator ShowMessage(string message, float duration)
    {
        //visible
        canvasGroup.alpha = 1;
        messageText.text = message;
        //wait for duration
        yield return new WaitForSeconds(duration);
        canvasGroup.alpha = 0;
    }
}
