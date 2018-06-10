using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    private Image _image;

    private string _title;
    private string _description;


    private void Awake()
    {
        _image = GetComponent<Image>();

        GetComponent<Button>().onClick.AddListener(OnButtonClicked);
    }


    public void Initialize(Sprite sprite, string title, string description)
    {
        _image.sprite = sprite;
        _title = title;
        _description = description;
    }


    private void OnButtonClicked()
    {
        // open image fullscreen
        Debug.Log("Open image fullscreen with description and title.");
        Debug.Log("title: " + _title + " / description: " + _description);
    }
}