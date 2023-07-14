namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class StringEventListener : MonoBehaviour {
		
		[SerializeField]
		private StringEvent @event;
		[SerializeField]
		private UnityEvent<string> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(string value) => onInvoke?.Invoke(value);
	}
}
