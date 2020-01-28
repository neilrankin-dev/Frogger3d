using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private enum PlatformDirection {WEST, EAST}

    [SerializeField]
    private PlatformDirection platformDirection;

    [SerializeField]
    private float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (platformDirection == PlatformDirection.WEST)
        {
            transform.Translate(-Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (platformDirection == PlatformDirection.EAST)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
