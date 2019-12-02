using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene02 : MonoBehaviour {
	public Image Picture;
	public Button CameraAnimation2;
	// Use this for initialization
	void Start () {
		Picture = CameraController.gPicture;
	}
	
	// Update is called once per frame
	IEnumerator EnableChange () {
		CameraAnimation2.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(5);
        CameraAnimation2.GetComponent<Button>().interactable = true;
	}

	public void ChangeScene(){
		Application.LoadLevel("Scene_01");
	}
}
