using UnityEngine;
using System.Collections;

public class RotateCubeMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * -Input.GetAxis ("Mouse X") * 200 * Time.deltaTime);
		transform.Rotate (Vector3.right * -Input.GetAxis ("Mouse Y") * 200 * Time.deltaTime);
	}
}
