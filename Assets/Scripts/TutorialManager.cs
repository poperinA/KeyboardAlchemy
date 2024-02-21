using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject Screen1;

    public GameObject Screen2;

    public GameObject Screen3;

    public GameObject Screen4;


    private void Start()
    {
        if (Screen1 != null)
        {
            Screen1.SetActive(true);
        } 
    }

    public void Stage1_1()
    {
        if (Screen1 != null)
        {
            Screen1.SetActive(false);
        }

        if (Screen2 != null)
        {
            Screen2.SetActive(true);
        }
    }

    public void Stage1_2()
    {
        if (Screen2 != null)
        {
            Screen2.SetActive(false);
        }

        if (Screen3 != null)
        {
            Screen3.SetActive(true);
        }
    }
}
