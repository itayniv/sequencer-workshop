using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BperM : MonoBehaviour {

    private static BperM _BperMInstance;
    public float _bpm;
    private float _beatInterval, _beatTimer, _beatIntervalD8, _beatTimerD8;
    public static bool _beatFull, _beatD8;
    public static int _beatCountFull, _beatCountD8;



    //when you are awake check that there is only one instance of _bpermInstance, kill others.
    private void Awake()
    {
        
        if(_BperMInstance != null && _BperMInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _BperMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //run the beat detection function every frame.
        BeatDetection();
	
	}



    //beat Detection
    void BeatDetection()
    {
        // full beat count
        _beatFull = false;

        //a beat interval equals to beets per minute
        _beatInterval = 60 / _bpm;

        // add time 
        _beatTimer += Time.deltaTime;

        //check when a beat should end
        if(_beatTimer >= _beatInterval)
        {
            _beatTimer -= _beatInterval;
            _beatFull = true;
            _beatCountFull++;
            //Debug.Log("full");

        }

        //divided beatcount
        _beatD8 = false;
        _beatIntervalD8 = _beatInterval / 8;
        _beatTimerD8 += Time.deltaTime;

        if(_beatTimerD8>=_beatIntervalD8)
        {
            _beatTimerD8 -= _beatIntervalD8;
            _beatD8 = true;
            _beatCountD8++;
            //Debug.Log("D8");
        }

    }
}
