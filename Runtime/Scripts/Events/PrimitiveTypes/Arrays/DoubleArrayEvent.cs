namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Double Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Double Array Event", order = 3)]
	public class DoubleArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<double[]> OnInvoked;

		public void Invoke(double[] value) => OnInvoked?.Invoke(value);
	}
}
