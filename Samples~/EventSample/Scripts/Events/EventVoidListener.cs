using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableEvents.Events;
using UnityEngine;

public class EventVoidListener : MonoBehaviour {
	
	[SerializeField]
	private VoidEvent voidEvent;

	[Header("References")]
	[SerializeField]
	private GameObject prefabBall;

	private void OnEnable() {
		if(voidEvent != null)
			voidEvent.OnInvoked += SpawnBall;
	}

	private void OnDisable() {
		if(voidEvent != null)
			voidEvent.OnInvoked -= SpawnBall;
	}

	private void SpawnBall() {
		Instantiate(prefabBall, transform.position, Quaternion.identity);
	}

}