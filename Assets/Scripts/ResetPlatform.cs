using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlatform : MonoBehaviour
{
    private MovingPlatform movingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        movingPlatform = GetComponent<MovingPlatform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingPlatform != null)
        {
            if (movingPlatform.platformDirection == MovingPlatform.PlatformDirection.WEST)
            {
                if (transform.position.x <= -12.5f)
                {
                    Vector3 resetPos = new Vector3(33f, transform.position.y, transform.position.z);
                    transform.position = resetPos;
                }
            }

            if (movingPlatform.platformDirection == MovingPlatform.PlatformDirection.EAST)
            {
                if (transform.position.x >= 31f)
                {
                    Vector3 resetPos = new Vector3(-12.5f, transform.position.y, transform.position.z);
                    transform.position = resetPos;
                }
            }
        }
           
    }
}
