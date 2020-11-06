﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "String Event", menuName = "Scriptable Events/Primitive Types/String Event", order = 5)]
	public class StringEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<string> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(string value) => OnTrigger?.Invoke(value);
	}
}