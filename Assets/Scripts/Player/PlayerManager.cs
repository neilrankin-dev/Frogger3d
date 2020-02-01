using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Vector3 startPos;
    GameManager gameManager;
    AnimatePlayer animatePlayer;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(10f, 11.5f, 3);
        gameManager = FindObjectOfType<GameManager>();
        animatePlayer = GetComponentInChildren<AnimatePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                animatePlayer.StartAnimate();
                ResetPlayerPos();
                isDead = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hazard") && !isDead)
        {
            gameManager.LoseLife();
            isDead = true;
            animatePlayer.AnimateDeath();
        }
    }

    public void ResetPlayerPos()
    {
        transform.position = startPos;
    }

}
