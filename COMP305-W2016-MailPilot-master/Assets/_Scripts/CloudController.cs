using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float minVspeed = 5f;
    public float maxVSpeed = 10f;
    public float minHspeed = -2f;
    public float maxHSpeed = 2f;
    public float _verticalSpeed;
    public float _horizontalDrift;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private 

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Island Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(Random.Range(this.minVspeed,this.maxVSpeed),0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= 825)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._verticalSpeed = Random.Range(this.minVspeed, this.maxVSpeed);
        this._verticalSpeed = Random.Range(this.minHspeed, this.maxHSpeed);
        float yPosition = Random.Range(116, -518);
        this._transform.position = new Vector2(825, yPosition);
    }
}
