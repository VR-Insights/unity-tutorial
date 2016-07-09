namespace io.vrinsights.unity.tutorials.tutorial1
{

	using UnityEngine;
	using System.Collections;

	public class ChangeColour : MonoBehaviour
	{

		// Use this for initialization
		void Start ()
		{
		
		}
		
		// Update is called once per frame
		void Update ()
		{
			if (Input.GetKeyDown (KeyCode.R)) {
				gameObject.GetComponent<Renderer> ().material.color = Color.red;
			} else if (Input.GetKeyDown (KeyCode.G)) {
				gameObject.GetComponent<Renderer> ().material.color = Color.green;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				gameObject.GetComponent<Renderer> ().material.color *= 0.9f;
			}
		}
	}
}