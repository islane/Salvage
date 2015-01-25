using UnityEngine;
using System.Collections;

public class WaterDrops : MonoBehaviour {

	public Rigidbody2D projectile;
	void Update() {
			Rigidbody2D clone;
			clone = (Rigidbody2D)Instantiate(projectile, transform.position, transform.rotation);
			clone.velocity = transform.TransformDirection(Vector3.down * 10);
		}

	void OnCollisionEnter2D(Collision2D other) {
			if (other.gameObject.tag == "Floor") {
					Debug.Log ("Water hit the floor");
						Destroy (gameObject);
				}
		}
}