using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Int Event", menuName = "Scriptable Events/Primitive Types/Int Event", order = 12)]
	public class IntEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<int> OnInvoked;
		
		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(int value) => OnInvoked?.Invoke(value);
	}
}