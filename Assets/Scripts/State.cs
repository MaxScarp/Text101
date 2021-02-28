using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates; 

    /// <summary>
    /// Ritorna la stringa storyText contenente la storia dello State attuale.
    /// </summary>
    /// <returns></returns>
    public string GetStateStory()
    {
        return storyText;
    }

    /// <summary>
    /// Ritorna un Array di State che rappresenta tutti gli State successivi a quello attuale.
    /// </summary>
    /// <returns></returns>
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
