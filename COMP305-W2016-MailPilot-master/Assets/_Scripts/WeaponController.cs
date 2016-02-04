using UnityEngine;
using System.Collections;


public class WeaponController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float minVerticalspeed =5f;
    public float maxVerticalspeed = 10f;
    public float minHorizontalspeed = 2f;
    public float maxHorizontalspeed = -2f;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalSpeed;
    private float _horizontalDrift;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Weapon Sprite to the Right
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._verticalSpeed, this._horizontalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -540)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._verticalSpeed = Random.Range(this.minVerticalspeed, this.maxVerticalspeed);
        this._horizontalDrift = Random.Range(this.minHorizontalspeed, this.maxHorizontalspeed);
        float yPosition = Random.Range(-150f, 150f);
        this._transform.position = new Vector2(540f, yPosition);
    }
}
