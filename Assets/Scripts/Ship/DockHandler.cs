using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockHandler : MonoBehaviour
{

    [SerializeField]
    private GameObject _dock;

    private void attach(GameObject dock)
    {
        _dock = dock;
    }

    private void dettach()
    {
        _dock = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Dock")
        {
            _dock = collision.gameObject;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _dock.transform.position;
        transform.rotation = _dock.transform.rotation;
    }
}
