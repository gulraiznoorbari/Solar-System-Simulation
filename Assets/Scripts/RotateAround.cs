using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{
	[SerializeField] private Transform target;
	[SerializeField] private int speed; 
	
	private void Start() {
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("RotateAround target not specified. Defaulting to this GameObject");
		}
	}

	private void Update () {
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
	}
}
