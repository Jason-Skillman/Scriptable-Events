﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Float Event", menuName = "Scriptable Events/Primitive Types/Float Event", order = 13)]
	public class FloatEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<float> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(float value) => OnTrigger?.Invoke(value);
	}
}