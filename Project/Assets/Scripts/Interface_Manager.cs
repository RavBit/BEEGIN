using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Interface_Manager : MonoBehaviour {
    [Header("Toolbar Components")]
    public Image Toolbar;
    [Range(0, 1)]
    [SerializeField]
    private float ToolbarSpeed = 0.5f;
    private bool toggled = false;
	// Use this for initialization
	void Start () {
	}


    public void OnToggle()
    {
        toggled = !toggled;
        if(toggled)
        {
            Toolbar.gameObject.transform.DOMoveX(0, 1);
        }
        if (!toggled)
        {
            Toolbar.gameObject.transform.DOMoveX(-700, 1);
        }
    }
}
