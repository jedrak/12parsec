using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropDown : MonoBehaviour
{
    public Vector3 startSpeed, acceleration;
    private bool _isDraged;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        _isDraged = true;
        Vector3 buff = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(buff.x, buff.y, 0);
        _rb.velocity = new Vector2(startSpeed.x, startSpeed.y);
    }

    private void OnMouseUp()
    {
        _isDraged = false;
    }

    private void Update()
    {
        if (!_isDraged)
        {
            _rb.velocity +=  new Vector2 (acceleration.x, acceleration.y);
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }
    
        _rb.angularVelocity = startSpeed.magnitude * 50;
    }

}
