using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableEvents.Events;
using UnityEngine;

public class EventVoidTrigger : MonoBehaviour {

	[SerializeField]
	private EventVoid voidEvent;

	private void OnTriggerEnter(Collider other) {
		if(!other.CompareTag("Player")) return;
		
		if(voidEvent != null)
			voidEvent.Trigger();
	}

}