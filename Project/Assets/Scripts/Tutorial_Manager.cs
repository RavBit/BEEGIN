using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial_Manager : MonoBehaviour {
    public Image TutorialRenderer;
    public Sprite[] TutorialImages;
    public int imagecount = 0;

    private void Start()
    {
        TutorialRenderer.sprite = TutorialImages[imagecount];
    }
    public void NextTutButton()
    {
        Handheld.Vibrate();
        if (imagecount == TutorialImages.Length - 1)
        {
            SceneManager.LoadScene("Home_2");
            return;
        }
        imagecount++;
        TutorialRenderer.sprite = TutorialImages[imagecount];
    }
}
