using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject showFrog;
    public bool isActivated = false;

    GameManager gameManager;
    PlayerManager playerManager;
    AudioSource goalAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerManager = FindObjectOfType<PlayerManager>();
        goalAudio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isActivated)
        {
            goalAudio.Play();
            isActivated = true;
            showFrog.SetActive(true);
            gameManager.UpdateScore(500);
            playerManager.ResetPlayerPos();
        }
    }

}
