//Credit to "TheArtist" for this script http://answers.unity3d.com/users/515523/theartist.html & http://g23d.com for instructions.
/*
 * Put this script in a logical folder in your Unity3D project folders.
 * In the Unity3D editor go to the upper left menu and under "Game Object" select "Create Empty".  
 * Rename it in the Heirarchy tab as "Cameras".  Drag this script from the "Project" tab to
 * the "Cameras" empty game object in the Heirarchy tab.  Next go to the upper left menu and
 * under "Game Object" click "Camera". This adds and additional camera to your scene.  Rename this camera
 * "Camera2". Drag this new camera onto the "Cameras" 
 * empty game object in the heirarchy tab making it a child of that object for organizational purposes. Highlight 
 * this camera in the Heirarchy tab then in the Inspector tab select the "MainCamera" tag.  Now highlight the 
 * "Cameras" empty game object in the Heirarchy tab and in the inspector change the "Size" field to 2. Click the small
 * circle to the right of the first field and select the "MainCamera" then the second fields circle click and select
 * "Camera2".  Finally position this camera where you want and click the "Play" button.  Hit your "C" key to switch
 * views.  Add more cameras as needed.

 */
using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour {
	public Camera[] cameras;
	private int currentCameraIndex;
	
	// Use this for initialization
	void Start () {
		currentCameraIndex = 0;
		
		//Turn all cameras off, except the first default one
		for (int i=1; i<cameras.Length; i++) 
		{
			cameras[i].gameObject.SetActive(false);
		}
		
		//If any cameras were added to the controller, enable the first one
		if (cameras.Length>0)
		{
			cameras [0].gameObject.SetActive (true);
			Debug.Log ("Camera with name: " + cameras [0].GetComponent<Camera>().name + ", is now enabled");
		}
	}
	
	// Update is called once per frame
	void Update () {
		//If the c button is pressed, switch to the next camera
		//Set the camera at the current index to inactive, and set the next one in the array to active
		//When we reach the end of the camera array, move back to the beginning or the array.
		if (Input.GetKeyDown(KeyCode.C))
		{
			currentCameraIndex ++;
			Debug.Log ("C button has been pressed. Switching to the next camera");
			if (currentCameraIndex < cameras.Length)
			{
				cameras[currentCameraIndex-1].gameObject.SetActive(false);
				cameras[currentCameraIndex].gameObject.SetActive(true);
				Debug.Log ("Camera with name: " + cameras [currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");
			}
			else
			{
				cameras[currentCameraIndex-1].gameObject.SetActive(false);
				currentCameraIndex = 0;
				cameras[currentCameraIndex].gameObject.SetActive(true);
				Debug.Log ("Camera with name: " + cameras [currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");
			}
		}
	}
}
