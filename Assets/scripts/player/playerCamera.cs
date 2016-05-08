using UnityEngine;
using System.Collections;

public class playerCamera : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    void Update()
    {

        transform.position = new Vector3(player.transform.position.x,player.transform.position.y + 3,-50);

    }
}