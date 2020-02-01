using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Vector3 startPos;
    GameManager gameManager;
    AnimatePlayer animatePlayer;
    public bool isDead = false;
    public GameObject deathMenu;

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
            if (Input.GetKeyDown(KeyCode.Escape) && gameManager.playerLives > 0)
            {
                animatePlayer.StartAnimate();
                ResetPlayerPos();
                isDead = false;
                deathMenu.SetActive(false);
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

            if (gameManager.playerLives > 0)
            {
                deathMenu.SetActive(true);
            }
        }
    }

    public void ResetPlayerPos()
    {
        transform.position = startPos;
    }

}
