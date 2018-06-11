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
        if (imagecount == TutorialImages.Length - 1)
        {
            SceneManager.LoadScene("Home");
            return;
        }
        imagecount++;
        TutorialRenderer.sprite = TutorialImages[imagecount];
    }
}
