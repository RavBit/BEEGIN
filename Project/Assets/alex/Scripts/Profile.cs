using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    [SerializeField] private string _profession;
    [SerializeField] private Item[] _items;
    [SerializeField] private ProfileView TEST_VIEW;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClicked);
    }


    private void OnButtonClicked()
    {
        // open profile page and initialize it
        TEST_VIEW.Initialize(_items, _profession);
        Debug.Log("Open profile page with animation.");
    }
}