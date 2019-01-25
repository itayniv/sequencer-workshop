using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundsOnBeat : MonoBehaviour {

    public SoundManager _soundManager;
    public AudioClip _tap, _tick;
    public AudioClip[] _strum;

    public int counter = 0;

    int _randomStrum;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        //if (BperM._beatD8)
        //{
        //    counter++;
          
        //}


        //if(BperM._beatFull)
        //{
        //    //_soundManager.playSound(_tap, 1);
        //    if (BperM._beatCountFull % 2 == 0)
        //    {
        //        //_randomStrum = Random.Range(0, _strum.Length);
        //    }
        //}




        //if (BperM._beatD8 && BperM._beatCountD8 % 2 == 0)
        //{
        //    //_soundManager.playSound(_tick, 0.1f);
        //}

        //if(BperM._beatD8 && (BperM._beatCountD8 % 8 == 2 || BperM._beatCountD8 % 8 == 4))
        //{
        //    //_soundManager.playSound(_strum[_randomStrum], 1);
        //}
		
	}
}
