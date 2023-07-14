namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class FloatEventListener : MonoBehaviour {
		
		[SerializeField]
		private FloatEvent @event;
		[SerializeField]
		private UnityEvent<float> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(float value) => onInvoke?.Invoke(value);
	}
}
