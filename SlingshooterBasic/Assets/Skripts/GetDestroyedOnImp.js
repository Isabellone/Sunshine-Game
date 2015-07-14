#pragma strict

function OnTriggerEnter  (other : Collider) {

	if(other.tag == "Target"){

		Destroy (gameObject);
		Application.LoadLevel ("GoodEnd");
		

	}
	
	if(other.tag == "Ground"){

		Destroy (gameObject);
		Application.LoadLevel ("BadEnd");

	}

}