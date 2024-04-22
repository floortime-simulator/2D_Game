using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update

    Vector3 respawnLocation;
    void Start()
    {
        respawnLocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;

        if (player != null)
        {
            player.transform.position = respawnLocation;
        }
    }
}
