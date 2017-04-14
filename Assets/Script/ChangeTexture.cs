using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour {
	
	public Texture[] _textures;
	public Renderer _rend;
	public string _keyA;
	public string _keyB;
	int _index = 0;
	
	private bool isRunning = false;
	
	IEnumerator changeTex(float _sec){
		if (isRunning) yield break;
		
		isRunning = true;
		
		int _texNum = _textures.Length;
				
		if (Input.GetKey(_keyA))
		{
			_index += 1;
			
			if ( _index >= _texNum )
			{
				_index = 0;
			}
			_rend.material.mainTexture = _textures[_index];	
		}
		
		if (Input.GetKey(_keyB))
		{
			_index -= 1;
			
			if ( _index < 0 )
			{
				_index = _texNum - 1;
			}
			_rend.material.mainTexture = _textures[_index];	
		}
		
		yield return new WaitForSeconds(_sec);
		
		isRunning = false;
		Debug.Log("index" + _index);
		//Debug.Log("Tex" + _texNum);
	}

	// Use this for initialization
	void Start () {
		
		_rend = GetComponent<Renderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		StartCoroutine(changeTex(0.1f));
		
	}
}
