using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
	public WebCamTexture mCamera = null;
	//public GameObject plane;
	public Image CameraPlane;
	WebCamDevice[] devices; 
	public int cameraNumber = 0;

	public static Image gPicture = null;
	// Use this for initialization
	void Start ()
	{
		gPicture = null;
		Debug.Log ("Script has been started");
		//plane = GameObject.FindWithTag ("Player");



		mCamera = new WebCamTexture ();
		devices = WebCamTexture.devices;
//		plane.GetComponent<Renderer>().material.mainTexture = mCamera;
//		CameraPlane.GetComponent<SpriteRenderer> ().material.mainTexture = mCamera;

		mCamera.deviceName = devices[cameraNumber].name;
		CameraPlane.GetComponent<Image> ().material.mainTexture = mCamera;

		gPicture = CameraPlane;
//		CameraPlane.



		mCamera.Play ();

//		devices = WebCamTextureamTexture.devices;
//		webCamTexture = new WebCamTexture();
//		webCamTexture.deviceName = devices[0].name;
//		webCamTexture.Play();

	}

	// Update is called once per frame
	void Update ()
	{

	}
}