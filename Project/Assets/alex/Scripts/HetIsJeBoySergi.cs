using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HetIsJeBoySergi : MonoBehaviour
{
    [SerializeField] private ProjectCreate _projectCreate;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();

        _projectCreate.transform.DOMoveX(540, 0.3f);
        gameObject.SetActive(false);
    }
}