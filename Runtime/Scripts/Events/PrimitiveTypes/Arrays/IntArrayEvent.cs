﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Int Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Int Array Event", order = 1)]
	public class IntArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<int[]> OnInvoked;
		
		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(int[] value) => OnInvoked?.Invoke(value);
	}
}