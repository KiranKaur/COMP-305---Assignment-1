using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //  public instance variable
    public int cloudNumber=3;
    public CloudController cloud;

	// Use this for initialization
	void Start () {

        this._intialize();
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //PRIVATE METHODS
    //INTIALIZE METHOD
    private void _intialize()
    {
       for(int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++)
        {
            Instantiate(cloud.gameObject);
        }

    }
}
