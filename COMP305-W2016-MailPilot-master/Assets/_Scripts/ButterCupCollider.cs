using UnityEngine;
using System.Collections;

public class ButterCupCollider : MonoBehaviour {
    //  PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _starCollisionSound;
    private AudioSource _weaponCollisionSound;
    // PUBLIC INSTANCE VARIABLE
    public GameController gameController;

    // Use this for initialization
    void Start () {
        // INTIALIZE AUDIO SOURCE ARRAY
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._weaponCollisionSound = this._audioSources[1];
        this._starCollisionSound = this._audioSources[2];
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
   
        if (other.gameObject.CompareTag("Star"))
        {
            this._starCollisionSound.Play();
            Debug.Log("Star Collision");
            this.gameController.Scorevalue += 100;
            
        
        }
        if (other.gameObject.CompareTag("Weapon"))
        {
            this._weaponCollisionSound.Play();
            this.gameController.Livesvalue -= 1;
        }
    }
}
