using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProjectOverlay : MonoBehaviour
{
    [SerializeField] private Text _labelTitle;
    [SerializeField] private Text _labelSlogan;
    [SerializeField] private Text _labelDescription;
    [SerializeField] private Image _imageBee;

    private Image _image;
    private Button _buttonClose;
    private ProjectView _view;

    private void Awake()
    {
        _labelTitle.DOFade(0f, 0f);
        _labelSlogan.DOFade(0f, 0f);
        _labelDescription.DOFade(0f, 0f);

        _image = GetComponent<Image>();
        _buttonClose = GetComponent<Button>();

        _buttonClose.onClick.AddListener(OnButtonClicked);
    }

    public void Initialize(ProjectView view, string title, string slogan, string description)
    {
        _view = view;

        transform.gameObject.SetActive(true);

        _labelTitle.text = title.ToUpper();
        _labelSlogan.text = slogan;
        _labelDescription.text = description;

        _labelTitle.DOFade(1f, 0.3f);
        _labelSlogan.DOFade(1f, 0.3f);
        _labelDescription.DOFade(1f, 0.3f);

        _image.DOFade(1f, 0.3f);
        _imageBee.DOFade(1f, 0.3f);
    }


    private void OnButtonClicked()
    {
        _labelTitle.DOFade(0f, 0.3f);
        _labelSlogan.DOFade(0f, 0.3f);
        _labelDescription.DOFade(0f, 0.3f);

        _image.DOFade(0f, 0.3f).OnComplete(OnTweenCompleted);
        _imageBee.DOFade(0f, 0.3f);
        _view.OnOverlayClosed();
    }

    private void OnTweenCompleted()
    {
        transform.gameObject.SetActive(false);
    }
}