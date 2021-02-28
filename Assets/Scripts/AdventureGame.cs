using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State state;

	// Use this for initialization
	void Start()
	{
		state = startingState;
		textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update()
	{
		ManageState();

		if(Input.GetKeyDown(KeyCode.Q))
        {
			QuitGame();
        }
	}

	/// <summary>
	/// Controlla i vari stati di tutto il gioco.
	/// </summary>
	private void ManageState()
    {
		var nextStates = state.GetNextStates();

		for (int i = 0; i < nextStates.Length; i++)
		{
			if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
				state = nextStates[i];
            }
        }

		textComponent.text = state.GetStateStory();
	}

	/// <summary>
	/// Metodo che controlla se sono nell'editor o nel vero gioco e poi spegne il gioco.
	/// </summary>
	private void QuitGame()
    {
		#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
		#else
				 Application.Quit();
		#endif
	}
}
