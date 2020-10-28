using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "GameObject Event", menuName = "Scriptable Events/Unity/GameObject Event")]
	public class EventGameObject : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is triggered.
		/// </summary>
		public event UnityAction<GameObject> OnTrigger;
		
		/// <summary>
		/// Main method to call to trigger the event.
		/// </summary>
		public void Trigger(GameObject value) => OnTrigger?.Invoke(value);
	}
}