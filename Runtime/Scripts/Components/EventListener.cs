namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;
	using Event = JasonSkillman.ScriptableEvents.Event;

	public class EventListener : MonoBehaviour {

		[SerializeField]
		private Event @event;
		[SerializeField]
		private UnityEvent onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked() => onInvoke?.Invoke();
	}
}
