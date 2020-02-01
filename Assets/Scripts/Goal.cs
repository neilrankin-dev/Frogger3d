using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject showFrog;
    GameManager gameManager;
    PlayerManager playerManager;
    public bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerManager = FindObjectOfType<PlayerManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isActivated)
        {
            isActivated = true;
            showFrog.SetActive(true);
            gameManager.UpdateScore(500);
            playerManager.ResetPlayerPos();
        }
    }

}
