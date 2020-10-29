using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Bool Array Event", menuName = "Scriptable Events/Primitive Array Types/Bool Array Event", order = 3)]
	public class EventBoolArray : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<bool[]> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(bool[] value) => OnTrigger?.Invoke(value);
	}
}