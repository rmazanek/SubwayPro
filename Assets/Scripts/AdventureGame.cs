﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
   [SerializeField] Text textComponent;
   [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = state.GetNextStates();
        
        for (int index = 0; index < nextStates.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + index) | Input.GetKeyDown(KeyCode.Keypad1 + index))
            {
            state = nextStates[index];
            }

            if(Input.GetKeyDown(KeyCode.Q)) 
            {
            state = startingState;
            }
        }
        
        textComponent.text = state.GetStateStory();
        }
}
