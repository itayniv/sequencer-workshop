using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	//link to the prefab that is spawning
	public GameObject candy;


	public GameObject BridgeNetworkedHead;
	public GameObject BridgeLeftController;
	public GameObject BridgeRightController;


	public GameObject SteamVRNetworkedHead;
	public GameObject SteamVRLeftController;
	public GameObject SteamVRRightController;

	//link to the position where the candy spawn from
	public Transform candySpawnPosition;

	[SyncVar]
	public int numberofCandies = 0;

	// Use this for initialization
	void Start () {
		
		if (isLocalPlayer) {
			gameObject.name = "LocalPlayer";

			SteamVRNetworkedHead = FindObjectOfType<HeadObject> ().gameObject;
			SteamVRLeftController = FindObjectOfType<LeftHandController> ().gameObject;
			SteamVRRightController = FindObjectOfType<RighHandController> ().gameObject;


		} else {
			gameObject.name = "NetworkedPlayer";
		}
	}

	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer)
			return;

		// You are local player if above statement passes through
		//update Networked Objects Positions from Steam Vr

		BridgeNetworkedHead.transform.position = SteamVRNetworkedHead.transform.position;
		BridgeLeftController.transform.position = SteamVRLeftController.transform.position;
		BridgeRightController.transform.position = SteamVRRightController.transform.position;

		BridgeNetworkedHead.transform.rotation = SteamVRNetworkedHead.transform.rotation;
		BridgeLeftController.transform.rotation = SteamVRLeftController.transform.rotation;
		BridgeRightController.transform.rotation = SteamVRRightController.transform.rotation;
		
		

		if (Input.GetKeyDown(KeyCode.Space))
		{

			CmdCreateCandy();
		}
	}

	[Command]
	void CmdCreateCandy() {

		GameObject candyInTheScene = (GameObject)Instantiate (
			candy, 
			candySpawnPosition.
			position,
			candySpawnPosition.rotation);

		// Add velocity to the candy
		candyInTheScene.GetComponent<Rigidbody>().velocity = candyInTheScene.transform.forward * 6;

		NetworkServer.Spawn (candyInTheScene);

		numberofCandies++;

		// Destroy the candy after 2 seconds
		Destroy(candyInTheScene, 2.0f);        

	}
}
