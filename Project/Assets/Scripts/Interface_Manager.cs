using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface_Manager : MonoBehaviour {
    [Header("Toolbar Components")]
    public Image Toolbar;
    private bool toggled = false;
	// Use this for initialization
	void Start () {
		
	}


    public void OnToggle()
    {
        toggled = !toggled;

    }
}
