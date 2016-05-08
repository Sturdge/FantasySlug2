using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

    [SerializeField]
    private GameObject player;

	void Update () {

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 5);

	}
}
