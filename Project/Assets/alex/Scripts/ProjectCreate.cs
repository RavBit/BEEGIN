using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProjectCreate : MonoBehaviour
{
    [SerializeField] private InputField _inputTitle;
    [SerializeField] private InputField _inputDescription;
    [SerializeField] private Button _buttonSend;

    [SerializeField] private ProjectView _geforceerdProjectOmTeOpenen;

    private void Awake()
    {
        _buttonSend.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {

        _geforceerdProjectOmTeOpenen.AaplexEnSnelgiGingenWandelenMaarToenKwamBus12(_inputTitle.text, _inputDescription.text);
        _geforceerdProjectOmTeOpenen.gameObject.SetActive(true);

        transform.DOMoveX(1640, 0.3f);
    }
}