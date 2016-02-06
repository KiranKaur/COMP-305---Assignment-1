using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;
    [SerializeField]
    private AudioSource _gameOverSound;

    //PUBLIC INSTANCE VARIABLE
    public int weaponNumber = 3;
    public WeaponController weapon;
    public PlaneController buttercup;
    public IslandController star;
    public Text LiveLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public Button RestartButton;

	// PUBLIC ACCESS METHOD
    public int Scorevalue
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score:" + this._scoreValue;
        }
    }
    public int Livesvalue
    {
        get
        {
            return this._livesValue;
        }
        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.LiveLabel.text = "Lives:" + this._livesValue;
            }
        }
    }
    //Use this for initialization

    void Start () {

        this._intialize();
       
       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void _intialize()
    {
      
        this.Scorevalue = 0;
        this.Livesvalue = 5;
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);

        for(int weaponCount= 0;weaponCount<this.weaponNumber;weaponCount++)
            Instantiate (weapon.gameObject);
    }
    private void _endGame()
    {
        this.HighScoreLabel.text = "HighScore:" + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this.LiveLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.buttercup.gameObject.SetActive(false);
        this.star.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(true);
        this._gameOverSound.Play();
    }
    //Public Methods
    public void RestartButtonClick()
    {
        Application.LoadLevel("Main");
    }
}
