using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropDown : MonoBehaviour
{


    private void OnMouseDown()
    {
        Debug.Log("MouseClick");
    }

    private void OnMouseDrag()
    {
        Vector3 buff = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(buff.x, buff.y, 0);
        Debug.Log(transform.position);
    }



}
