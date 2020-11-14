using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Double Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Double Array Event", order = 3)]
	public class DoubleArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<double[]> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(double[] value) => OnTrigger?.Invoke(value);
	}
}