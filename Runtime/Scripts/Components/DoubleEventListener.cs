namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class DoubleEventListener : MonoBehaviour {
		
		[SerializeField]
		private DoubleEvent @event;
		[SerializeField]
		private UnityEvent<double> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(double value) => onInvoke?.Invoke(value);
	}
}
