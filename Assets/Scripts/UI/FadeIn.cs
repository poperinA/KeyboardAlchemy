using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public CanvasGroup titleCanvasGroup;
    public CanvasGroup[] buttonCanvasGroups;

    public float fadeInDuration = 1f;
    public float delayBetweenElements = 1f;

    void Start()
    {
        // Set initial alpha to 0 for all elements
        titleCanvasGroup.alpha = 0f;
        foreach (CanvasGroup buttonCanvasGroup in buttonCanvasGroups)
        {
            buttonCanvasGroup.alpha = 0f;
        }

        // Start the fade-in animation with staggered timings
        LeanTween.alphaCanvas(titleCanvasGroup, 1f, fadeInDuration)
            .setEase(LeanTweenType.easeOutQuad)
            .setDelay(0f); // No delay for title

        for (int i = 0; i < buttonCanvasGroups.Length; i++)
        {
            LeanTween.alphaCanvas(buttonCanvasGroups[i], 1f, fadeInDuration)
                .setEase(LeanTweenType.easeOutQuad)
                .setDelay((i + 1) * delayBetweenElements); // Apply delay for buttons
        }
    }
}
