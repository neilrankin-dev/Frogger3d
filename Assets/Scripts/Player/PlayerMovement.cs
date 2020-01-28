using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum PlayerDirection {NORTH, SOUTH, EAST, WEST};
    public PlayerDirection playerDirection;

    public float movementSpeed = 5f;
    Quaternion resetRotation = new Quaternion(0, 0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (verticalMovement > 0 && horizontalMovement == 0)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

            if (playerDirection != PlayerDirection.NORTH)
            {
                playerDirection = PlayerDirection.NORTH;
                transform.rotation = resetRotation;
            }
        }
        if (verticalMovement < 0 && horizontalMovement == 0)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

            if (playerDirection != PlayerDirection.SOUTH)
            {
                playerDirection = PlayerDirection.SOUTH;
                transform.rotation = resetRotation;
                transform.Rotate(0, -180, 0);
            }
        }

        if (horizontalMovement > 0 && verticalMovement == 0)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            if (playerDirection != PlayerDirection.EAST)
            {
                playerDirection = PlayerDirection.EAST;              
                transform.rotation = resetRotation;
                transform.Rotate(0, 90, 0);
            }
        }

        if (horizontalMovement < 0 && verticalMovement == 0)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

            if (playerDirection != PlayerDirection.WEST)
            {
                playerDirection = PlayerDirection.WEST;
                transform.rotation = resetRotation;
                transform.Rotate(0, -90, 0);
            }
        }

    }
}
