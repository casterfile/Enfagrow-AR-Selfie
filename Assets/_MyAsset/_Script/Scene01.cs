using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour {
	public GameObject CameraStatic, CameraAnimation;
	// Use this for initialization
	void Start () {
		CameraStatic.SetActive(true);
		CameraAnimation.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScene(){
		StartCoroutine(ChangeSceneStart());
	}

	IEnumerator ChangeSceneStart()
    {
        CameraStatic.SetActive(false);
		CameraAnimation.SetActive(true);
        yield return new WaitForSeconds(1);
        Application.LoadLevel("Scene_02");
    }
}
