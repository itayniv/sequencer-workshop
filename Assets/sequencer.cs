using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public class sequencer : NetworkBehaviour
{

    public GameObject pad;
    public Material[] materials;
    private int counter = 0;
    public AudioClip _hiHat, _baseDrum, _snareDrum, _sound01, _sound02, _sound03, _sound04, _sound05;
    private int padNumbers = -1;
    public bool[] patterns;


   
    public int[] pattern;


    public List<GameObject> _PadsArr = new List<GameObject>();

    public int instruments = 3;
    private int steps = 8;

    public SoundManager _soundManager;



    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

        //declare length of array
        patterns = new bool[instruments * steps];
        pattern = new int[steps];


        for (int x = 0; x < steps; x++)
        {
            pattern[x] = 0;
        }


        for (int y = 0; y < instruments; y++)
        {
            for (int x = 0; x < steps; x++)
            {
                //Debug.Log(instruments);
                padNumbers++;
                GameObject _pad = Instantiate(pad);
                _pad.name = "pad" + padNumbers;
                _pad.transform.position = new Vector3(x, 0, y);
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
        // clear pattern for curser
        for (int z = 0; z < instruments * steps; z++)
        {
            if (patterns[z] == true)
            {
                _PadsArr[z].GetComponent<Renderer>().material = materials[1];
            }
        }


        if (BperM._beatD8)
        {
            
            if (BperM._beatD8 && BperM._beatCountD8 % 2 == 0)
            {
                
                counter++;


                if (counter >= 8)
                {
                    counter = 0;
                }


                //Reset Pattern
                for (int i = 0; i < steps; i++)
                {
                    pattern[i] = 0;
                }


                for (int i = 0; i < instruments * steps; i++)
                {


                    switch (counter)
                    {
                        //for voice #1
                        case 0:

                            if (patterns[i] != true)
                            {
                                _PadsArr[i].GetComponent<Renderer>().material = materials[0];
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


                //move Click
                pattern[counter] = 1;

                for (int i = 0; i < steps; i++)
                {

                    if ((patterns[(8 * 0) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_baseDrum, 0.1f);
                    }

                    if ((patterns[(8*1)+i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_hiHat, 0.1f);
                    }

                    if ((patterns[(8 * 2) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_snareDrum, 0.1f);
                    }

                    if ((patterns[(8 * 3) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound01, 0.1f);
                    }

                    if ((patterns[(8 * 4) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound02, 0.1f);
                    }

                    if ((patterns[(8 * 5) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound03, 0.1f);
                    }

                    if ((patterns[(8 * 6) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound04, 0.1f);
                    }

                    if ((patterns[(8 * 7) + i] == true) && pattern[i] == 1)
                    {
                        _soundManager.playSound(_sound05, 0.1f);
                    }

                }
         
            }

        }

    }




    public void patternCheck(GameObject padClicked)
    {
        //Debug.Log(padClicked);

        Debug.Log(padClicked.transform.localScale.y);


        string thisPadName = padClicked.name;
        //Debug.Log(thisPadName);

        for (var i = 0; i < _PadsArr.Count; i++)
        {
           
            //Determine which pad plays and which does not.

            string checkName = _PadsArr[i].name;
            if (thisPadName == checkName)
            {
                //Debug.Log(checkName + " " + i);

                if (patterns[i] == true)
                {
                    patterns[i] = false;
                    _PadsArr[i].transform.localScale = new Vector3 (0.8f, .4f, 0.8f);
                    //Debug.Log(patterns[i]);
                }
                else
                {
                    Debug.Log(_PadsArr[i].transform.localScale.y);
                    _PadsArr[i].transform.localScale = new Vector3 (0.8f, 0.2f, 0.8f);
                    patterns[i] = true;
                    //Debug.Log(patterns[i]);
                }

            }
        }
    }
}

