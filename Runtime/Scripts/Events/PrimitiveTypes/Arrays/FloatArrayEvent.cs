using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Float Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Float Array Event", order = 2)]
	public class FloatArrayEvent : ScriptableObject {
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