using UnityEngine;

public class ScaleAnim : MonoBehaviour
{
    public float scaleFactor;
    public float tweenTime;

    public void Start()
    {
        //Debug.Log("HELLO"); 
    }
    public void ScaleUp()
    {
        //Debug.Log("Scale Up Called");

        LeanTween.cancel(gameObject);

        // Initial scale
        transform.localScale = Vector3.one;

        // Tween to the target scale
        LeanTween.scale(gameObject, Vector3.one * scaleFactor, tweenTime)
            .setEase(LeanTweenType.easeOutExpo).setOnStart(() =>
            {
                //Debug.Log("Scale Up Animation Started");
            })
            .setOnComplete(() =>
            {
                //Debug.Log("Scale Up Animation Completed");
            });


    }

    public void ScaleDown()
    {
        //Debug.Log("Scale Down Called");

        LeanTween.cancel(gameObject);

        // Tween from current scale to the original scale (Vector3.one)
        LeanTween.scale(gameObject, Vector3.one, tweenTime)
            .setEase(LeanTweenType.easeOutExpo).setOnStart(() =>
            {
                //Debug.Log("Scale Down Animation Started");
            })
            .setOnComplete(() =>
            {
                //Debug.Log("Scale Down Animation Completed");
            });
    }

}
