using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class sequencer : MonoBehaviour{
    
    // Declaration of a pad
    public GameObject pad;

    //declaration of an array of materials
    public Material[] materials;

    //declaration of a counter
    private int counter = 0;

    //decleration of all the sounds --> one for each instrument.
    public AudioClip _hiHat, _baseDrum, _snareDrum, _sound01, _sound02, _sound03, _sound04, _sound05;

    //
    private int padNumbers = -1;

    //declaration of an array of booleans that would hold the state of the sequencer (all nontation)
    public bool[] patterns;

    //declaration of the an array that would hold the current state of the sequencer in (what step is currently playing)
    public int[] pattern;


    //declaration of a list of game objects to hold all pads
    public List<GameObject> _PadsArr = new List<GameObject>();


    //declaration of instrument number
    public int instruments = 3;

    //declaration of number of steps
    private int steps = 8;


    //declarationof soundmanager script
    public SoundManager _soundManager;



    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        //
        audioSource = GetComponent<AudioSource>();

        //declare length of array of patterns --> this would hold the map to which pads to play
        patterns = new bool[instruments * steps];

        //Declare length of pattern array --> this would hold the number of steps ( [0] [0] [0] [0] [0] [0] [0] [0] )
        pattern = new int[steps];



        //reset pattern array to 0
        for (int x = 0; x < steps; x++)
        {
            pattern[x] = 0;
        }



        //create all pads on the scene 2D array
        for (int y = 0; y < instruments; y++)
        {
            for (int x = 0; x < steps; x++)
            {
                //This is for the name of pads -->each should have a uniqy name.
                padNumbers++;

                //instantiat gameobjects Pad
                GameObject _pad = Instantiate(pad);

                //give pad a uniqu name
                _pad.name = "pad" + padNumbers;

                //place pad in a uniqu position
                _pad.transform.position = new Vector3(x, 0, y);

                //add a material for pad from the array of materials
                _pad.GetComponent<Renderer>().material = materials[0];
                _PadsArr.Add(_pad);

                //declare patterns are false
                patterns[padNumbers] = false;

            }
        }
    }




    // Update is called once per frame
    void Update()
    {
        // for all the pads that are currently on, assign a specific material
        for (int z = 0; z < instruments * steps; z++)
        {
            if (patterns[z] == true)
            {
                _PadsArr[z].GetComponent<Renderer>().material = materials[1];
            }
        }



        //on each beat from the metronome do the following:
        if (BperM._beatD8)
        {
               
            if (BperM._beatD8 && BperM._beatCountD8 % 2 == 0)
            {
                // add step
                counter++;



                //if step is larger than 8 than reset
                if (counter >= 8)
                {
                    counter = 0;
                }


                //Reset Pattern
                for (int i = 0; i < steps; i++)
                {
                    pattern[i] = 0;
                }




                // assign material for cursor, etc.
                for (int i = 0; i < instruments * steps; i++)
                {

                    //for each step number do the following (switch statement):
                    switch (counter)
                    {
                        //for voice #1
                        case 0:

                            if (patterns[i] != true)
                            {
                                //clear the color
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                //than assign it a "playing color" color
                                _PadsArr[0].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[0 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;

                        //for voice #2
                        case 1:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[1 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;


                        case 2:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[2 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;



                        case 3:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[3 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;
                        //for voice #5

                        case 4:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[4 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;
                        //for voice #6

                        case 5:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[5 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;



                        case 6:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[6 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;



                        case 7:
                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
                                _PadsArr[7].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 1].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 2].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 3].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 4].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 5].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 6].GetComponent<Renderer>().material = materials[2];
                                _PadsArr[7 + steps * 7].GetComponent<Renderer>().material = materials[2];
                            }

                            break;
                    }
                }


                //move counter on each counter --> [1],[0],[0],[0],[0],[0],[0],[0] --> [0],[1],[0],[0],[0],[0],[0],[0]
                pattern[counter] = 1;

                //for all the steps check what to play
                for (int i = 0; i < steps; i++)
                {

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 0) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_baseDrum, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8*1)+i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_hiHat, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 2) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_snareDrum, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 3) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound01, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 4) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound02, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 5) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound03, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 6) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound04, 0.1f);
                    }

                    //for first row of pads if a pad is pressed and the cursor is at the position than play
                    if ((patterns[(8 * 7) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound05, 0.1f);
                    }

                }
         
            }

        }

    }







    // from raycasting script
    public void patternCheck(GameObject padClicked)
    {
        
        string thisPadName = padClicked.name;


        //for the length of the padds Array
        for (var i = 0; i < _PadsArr.Count; i++)
        {
            //Determine which pad plays and which should not by name
            string checkName = _PadsArr[i].name;

            if (thisPadName == checkName)
            {

                //for the pressed gameobjects check if the number of array is true or false
                if (patterns[i] == true)
                {
                    //if it is true(pressed) make it unpressed
                    patterns[i] = false;
                    _PadsArr[i].transform.localScale = new Vector3 (0.8f, .4f, 0.8f);
                }
                else
                {
                    //if it is false(unpressed) make it pressed
                    _PadsArr[i].transform.localScale = new Vector3 (0.8f, 0.2f, 0.8f);
                    patterns[i] = true;
                }

            }
        }
    }
}

