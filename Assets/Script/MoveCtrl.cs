using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour {

    public GameObject _moveNode;
    public float _offset;
    public string _keyForward;
    public string _keyBack;
    public string _keyUp;
    public string _keyDown;

    void moving()
    {

        if (Input.GetKey(_keyForward))
        {
	        _moveNode.transform.Translate(Vector3.forward * Time.deltaTime * _offset, Space.World);
        }

        if (Input.GetKey(_keyBack))
        {
	        _moveNode.transform.Translate(Vector3.back * Time.deltaTime * _offset, Space.World);
        }

        if (Input.GetKey(_keyUp))
        {
            _moveNode.transform.Translate(Vector3.up * Time.deltaTime * _offset, Space.World);
        }

        if (Input.GetKey(_keyDown))
        {
            _moveNode.transform.Translate(Vector3.down * Time.deltaTime * _offset, Space.World);
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        moving();
		
	}
}
