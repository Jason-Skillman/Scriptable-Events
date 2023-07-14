namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;
	using Event = JasonSkillman.ScriptableEvents.Event;

	public class EventInvoker : MonoBehaviour {

		[SerializeField]
		private Event @event;

		[ContextMenu("Invoke")]
		public void Invoke() {
			if(@event == null) return;
			@event.Invoke();
		}
	}
}
