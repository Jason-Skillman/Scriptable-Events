namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class LongEventListener : MonoBehaviour {
		
		[SerializeField]
		private LongEvent @event;
		[SerializeField]
		private UnityEvent<long> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(long value) => onInvoke?.Invoke(value);
	}
}
