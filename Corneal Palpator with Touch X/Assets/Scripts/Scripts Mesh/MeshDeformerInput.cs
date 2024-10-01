using UnityEngine;

public class MeshDeformerInput : MonoBehaviour {
	
	public float force;
	public float forceOffset = 0.1f;

	public  GameObject hapticDevice = null;  
	int buttonID = 0;
	public GameObject hapticManipulator = null;

	void Update () {
		if (Input.GetMouseButton(0) || hapticDevice.GetComponent<HapticPlugin>().Buttons [buttonID] == 1)  {
			HandleInput();
		}
	}
	/*void HandleInput () {
		Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Ray inputRay = Camera.main.ScreenPointToRay(hapticManipulator.transform.position);
		//print("mouse: " + Input.mousePosition);
		//print("haptics: " + hapticManipulator.transform.position);
		RaycastHit hit;
		
		if (Physics.Raycast(inputRay, out hit)) {
			MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();
			if (deformer) {
				Vector3 point = hit.point;
				point += hit.normal * forceOffset;
				deformer.AddDeformingForce(point, force);
			}
		}
	}*/
	void HandleInput () 
	{
		
		//Ray inputRay = Camera.main.ScreenPointToRay(hapticManipulator.transform.position);
		Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if (Physics.Raycast(inputRay, out hit)) {
			MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>(); // si el raycast formado por el raton y la camara cruza por el mesh
			//print(deformer);
			if (deformer) {
				//Vector3 point = hit.point; // POSICION DONDE DEFORMAR
				Vector3 point = hapticManipulator.transform.position;
				point += hit.normal * forceOffset;
				deformer.AddDeformingForce(point, force);
			}
		}
	}
}