using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	public string levelToLoad;
	float currentTime = 0f;
	float startingTime = 10f;

	[SerializeField] Text countdownText;

	private void Start()
	{
		currentTime = startingTime;
	}

	private void Update()
	{
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString ();

		if (currentTime <= 0)
		{
			Application.LoadLevel(levelToLoad);
		}
	}
}
