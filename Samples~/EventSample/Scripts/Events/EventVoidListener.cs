using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableEvents.Events;
using UnityEngine;

public class EventVoidListener : MonoBehaviour {
	
	[SerializeField]
	private VoidEvent voidEvent = default;

	[Header("References")]
	[SerializeField]
	private GameObject prefabBall = default;

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