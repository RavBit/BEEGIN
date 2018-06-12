using UnityEngine;
using System.Collections;

public class TestRotation : MonoBehaviour
{
    public Interface_Manager IM;
    float f_lastX = 0.0f;
    float f_difX = 0.5f;
    float f_steps = 0.0f;
    int i_direction = 1;

    public float z;
    public Quaternion rot;
    public int rotSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touches.Length == 0)
        {
            return;
        }
        Touch touch = Input.GetTouch(0);
        Debug.Log("touch " + touch.position);
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                z -= touchDeltaPosition.x * rotSpeed * Time.deltaTime;
                rot = Quaternion.Euler(0, 0, z);
                transform.rotation = rot;
            foreach(GameObject t in IM.SubMenus)
            {
                t.SetActive(false);
            }
            }
    }
}