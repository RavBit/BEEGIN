using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectJoin : MonoBehaviour
{
    [SerializeField] private Sprite _spriteActive;
    [SerializeField] private Sprite _spriteInactive;
    [SerializeField] private int _id;

    private Image _image;
    private Button _buttonJoin;
    private bool isActive;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _buttonJoin = GetComponent<Button>();
        _buttonJoin.onClick.AddListener(OnButtonClicked);

        isActive = false;
    }

    private void OnButtonClicked()
    {
        isActive = !isActive;

        _image.sprite = isActive ? _spriteActive : _spriteInactive;
        // set id somewhere to show it in liked projects
    }
}