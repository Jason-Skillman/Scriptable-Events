using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Double Event", menuName = "Scriptable Events/Primitive Types/Double Event", order = 14)]
	public class DoubleEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<double> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(double value) => OnTrigger?.Invoke(value);
	}
}