using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Double Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Double Array Event", order = 3)]
	public class DoubleArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<double[]> OnInvoked;
		
		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(double[] value) => OnInvoked?.Invoke(value);
	}
}