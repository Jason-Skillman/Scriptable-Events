using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Float Array Event", menuName = "Scriptable Events/Primitive Array Types/Float Array Event", order = 2)]
	public class EventFloatArray : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<float[]> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(float[] value) => OnTrigger?.Invoke(value);
	}
}