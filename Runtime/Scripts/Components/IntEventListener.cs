namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class IntEventListener : MonoBehaviour {
		
		[SerializeField]
		private IntEvent @event;
		[SerializeField]
		private UnityEvent<int> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(int value) => onInvoke?.Invoke(value);
	}
}
