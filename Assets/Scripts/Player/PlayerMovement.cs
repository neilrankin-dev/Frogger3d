using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum PlayerDirection {NORTH, SOUTH, EAST, WEST};
    public PlayerDirection playerDirection;

    public float movementSpeed = 5f;
    GameManager gameManager;
    PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerManager = GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerManager.isDead)
        {
            PlayerMovementHandler();
        }

    }

    void PlayerMovementHandler()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (verticalMovement > 0 && horizontalMovement == 0)
        {
            gameManager.UpdateScore(1);
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        if (verticalMovement < 0 && horizontalMovement == 0)
        {
            gameManager.UpdateScore(-1);
            transform.Translate(-Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (horizontalMovement > 0 && verticalMovement == 0)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (horizontalMovement < 0 && verticalMovement == 0)
        {
            transform.Translate(-Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
