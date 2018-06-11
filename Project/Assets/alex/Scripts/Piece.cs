using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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
        View.instance.DetailView.Initialize(_image.sprite, _title, _description);
        View.instance.DetailView.transform.DOMoveX(540, 0.3f);
        View.instance.SetHeader("Honey");
    }
}