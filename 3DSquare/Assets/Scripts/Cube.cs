using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public GameObject cube;
    public float moveSpeed = 200f;
    public float rotateSpeed = 200f;
    public float translateSpeed = 50f;

	// Use this for initialization
	void Start () {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0, 0);
        cube.GetComponent<Renderer>().material.color = Color.green;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            cube.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            cube.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            cube.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            cube.transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            cube.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            cube.transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) {
            cube.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            cube.transform.Rotate(-Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J)) {
            cube.transform.Translate(Vector3.forward * translateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K)) {
            cube.transform.Translate(-Vector3.forward * translateSpeed * Time.deltaTime);
        }
    }
}
