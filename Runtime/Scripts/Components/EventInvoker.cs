namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class EventInvoker : MonoBehaviour {

		[SerializeField]
		private VoidEvent @event;

		[ContextMenu("Invoke")]
		public void Invoke() {
			if(@event == null) return;
			@event.Invoke();
		}
	}
}
