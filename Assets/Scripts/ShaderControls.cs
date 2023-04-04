using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControls : MonoBehaviour
{
    [SerializeField] Material[] mats;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SwapTo(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SwapTo(2);
        }
        else if (Input.GetKey(KeyCode.Alpha8))
        {
            SwapTo(3);
        }
        else if (Input.GetKey(KeyCode.Alpha9))
        {
            SwapTo(4);
        }
        else if (Input.GetKey(KeyCode.Alpha0))
        {
            SwapTo(5);
        }
    }

    void SwapTo(int index)
    {
        this.gameObject.GetComponent<Renderer>().material = mats[index - 1];
    }


}
