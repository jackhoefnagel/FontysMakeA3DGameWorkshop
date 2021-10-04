using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupManager : MonoBehaviour {

    public static PickupManager instance;

    void Awake(){
        instance = this;
    }

    private List<PickupScript> activeCoins;
    private AudioSource coinPickupAudioSource;
    public AudioClip coinPickupSound;

    void Start(){
        GetAllActiveCoins();
        coinPickupAudioSource = GetComponent<AudioSource>();
    }

    private void GetAllActiveCoins(){
        activeCoins = new List<PickupScript>();
        GameObject[] coinsArray = GameObject.FindGameObjectsWithTag("Coin");
        foreach(GameObject coin in coinsArray){
            activeCoins.Add(coin.GetComponent<PickupScript>());
        }
    }

    public void PickupCoin(PickupScript coin){
        PlayCoinPickupSound();
        coin.gameObject.SetActive(false);
        activeCoins.Remove(coin);
        GameManager.instance.AddScore(coin.pickupScore);
    }

    private void PlayCoinPickupSound(){
        if(coinPickupAudioSource != null && coinPickupSound != null){
            coinPickupAudioSource.clip = coinPickupSound;
            coinPickupAudioSource.Play();
        }
    }
}
