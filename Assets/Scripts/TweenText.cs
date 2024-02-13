using UnityEngine;

public class TweenText : MonoBehaviour
{
    public float scaleFactor;
    public float tweenTime;


    public void ScaleUp()
    {
        LeanTween.cancel(gameObject);

        // Initial scale
        transform.localScale = Vector3.one;

        // Tween to the target scale
        LeanTween.scale(gameObject, Vector3.one * scaleFactor, tweenTime)
            .setEase(LeanTweenType.easeOutExpo);
    }

    public void ScaleDown()
    {
        LeanTween.cancel(gameObject);

        // Tween from current scale to the original scale (Vector3.one)
        LeanTween.scale(gameObject, Vector3.one, tweenTime)
            .setEase(LeanTweenType.easeOutExpo);
    }

}
