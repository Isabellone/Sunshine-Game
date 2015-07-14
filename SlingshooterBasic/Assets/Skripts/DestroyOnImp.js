#pragma strict

function OnTriggerEnter  (other : Collider) {

	if(other.tag == "Projectile"){

		Destroy (gameObject);

	}

}