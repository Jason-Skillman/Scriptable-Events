using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Long Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Long Array Event", order = 4)]
	public class LongArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<long[]> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(long[] value) => OnTrigger?.Invoke(value);
	}
}