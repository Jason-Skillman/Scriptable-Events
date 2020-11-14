using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Long Event", menuName = "Scriptable Events/Primitive Types/Long Event", order = 15)]
	public class LongEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<long> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(long value) => OnTrigger?.Invoke(value);
	}
}