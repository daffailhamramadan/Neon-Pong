using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource ballHitSFX;
    [SerializeField] private AudioSource playerWinSFX;
    [SerializeField] private AudioSource playerLoseSFX;


    private void Awake()
    {
        instance = this;
    }

    public void BallHitSFX()
    {
        ballHitSFX.Play();
    }

    public void BackgroundMusic()
    {
        backgroundMusic.Play();
    }

    public void PlayerWinSFX()
    {
        playerWinSFX.Play();
    }

    public void PlayerLostSFX()
    {
        playerLoseSFX.Play();
    }
}
