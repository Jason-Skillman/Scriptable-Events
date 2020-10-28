﻿using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableEvents.Events;
using UnityEngine;

public class EventVoidListener : MonoBehaviour {
	
	[SerializeField]
	private EventVoid voidEvent;

	[Header("References")]
	[SerializeField]
	private GameObject prefabBall;

	private void OnEnable() {
		voidEvent.OnTrigger += SpawnBall;
	}

	private void OnDisable() {
		voidEvent.OnTrigger -= SpawnBall;
	}

	private void SpawnBall() {
		Instantiate(prefabBall, transform.position, Quaternion.identity);
	}

}