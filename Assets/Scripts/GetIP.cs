using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GetIP : NetworkBehaviour {



	// Use this for initialization
	void Start () {
		string ip = Network.player.ipAddress;
		GameObject.Find ("NetworkManager").GetComponent<NetworkManager> ().networkAddress = ip;
	}

}
