using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProjectView : MonoBehaviour
{
    [SerializeField] private Button _buttonInformation;
    [SerializeField] private Text _labelTitle;
    [SerializeField] private Text _labelDescription;
    [SerializeField] private Image _imageLines;

    [SerializeField] private string _title;
    [SerializeField] private string _slogan;
    [SerializeField] private string _description;

    [SerializeField] private ProjectOverlay _projectOverlay;


    private void Awake()
    {
        _buttonInformation.onClick.AddListener(OnButtonClick);
    }


    private void OnButtonClick()
    {
        _projectOverlay.Initialize(this, _title, _slogan, _description);

        _buttonInformation.gameObject.SetActive(false);
        _imageLines.DOFade(0f, 0.3f);
    }


    public void OnOverlayClosed()
    {
        _buttonInformation.gameObject.SetActive(true);
        _imageLines.DOFade(1f, 0.3f);
    }


    public void AaplexEnSnelgiGingenWandelenMaarToenKwamBus12(string title, string description)
    {
        _labelTitle.text = title;

        _title = title;
        _description = description;
    }
}