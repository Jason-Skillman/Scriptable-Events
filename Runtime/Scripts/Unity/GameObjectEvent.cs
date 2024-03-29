﻿namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "GameObject Event", menuName = "Scriptable Events/Unity/GameObject Event", order = 1)]
	public class GameObjectEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<GameObject> OnInvoked;

		public void Invoke(GameObject value) => OnInvoked?.Invoke(value);
	}
}
