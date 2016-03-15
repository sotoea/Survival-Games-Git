using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerNetworkInit : NetworkBehaviour {

	[SerializeField] GameObject FPSC;

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GameObject.Find ("Scene Camera").SetActive (false);
			GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().enabled = true;
			FPSC.SetActive (true);
		}
	}

}
