﻿namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Long Event", menuName = "Scriptable Events/Primitive Types/Long Event", order = 15)]
	public class LongEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<long> OnInvoked;

		public void Invoke(long value) => OnInvoked?.Invoke(value);
	}
}
