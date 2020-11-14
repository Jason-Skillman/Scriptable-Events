﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Int Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Int Array Event", order = 1)]
	public class IntArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<int[]> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(int[] value) => OnTrigger?.Invoke(value);
	}
}