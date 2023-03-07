namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class EventListener : MonoBehaviour {

		[SerializeField]
		private VoidEvent @event;
		[SerializeField]
		private UnityEvent onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked() => onInvoke?.Invoke();
	}
}
