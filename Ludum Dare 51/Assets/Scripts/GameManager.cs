using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public LevelBuilder m_LevelBuilder;
	public GameObject m_NextButton;

	private bool m_ReadyForInput;
	public Player m_Player;

	private void Start()
	{
		m_LevelBuilder.Build();
		m_Player = FindObjectOfType<Player>();
	}

	private void Update()
	{
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveInput.Normalize();
		if(moveInput.sqrMagnitude > .5) //Button pressed or held
		{
			if (m_ReadyForInput)
			{
				m_ReadyForInput = false;
				m_Player.Move(moveInput);
				//_m_NextButton.SetActive(IsLevelComplete());
			}
		}
		else
		{
			m_ReadyForInput = true;
		}
	}
}
