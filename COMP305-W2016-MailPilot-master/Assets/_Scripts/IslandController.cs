using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Island Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -470) {
			this.Reset ();
		}
	}

	public void Reset() {
		float yPosition = Random.Range (-210f, 210f);
		this._transform.position = new Vector2 (460f,yPosition);
	}
}
