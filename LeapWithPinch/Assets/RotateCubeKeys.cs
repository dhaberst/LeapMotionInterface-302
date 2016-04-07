using UnityEngine;
using System.Collections;

public class RotateCubeKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.Rotate (Vector3.left * -Input.GetAxis ("Vertical") * 300 * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("down")) {
			transform.Rotate (Vector3.right * Input.GetAxis ("Vertical") * 300 * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("left")) {
			transform.Rotate (Vector3.up * Input.GetAxis ("Horizontal") * 300 * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("right")) {
			transform.Rotate (Vector3.down * -Input.GetAxis ("Horizontal") * 300 * Time.deltaTime, Space.World);
		}
	}
}
