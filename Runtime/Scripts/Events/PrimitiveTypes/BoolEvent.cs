using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Bool Event", menuName = "Scriptable Events/Primitive Types/Bool Event", order = 4)]
	public class BoolEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<bool> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(bool value) => OnTrigger?.Invoke(value);
	}
}