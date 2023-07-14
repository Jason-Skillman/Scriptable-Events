namespace JasonSkillman.ScriptableEvents.Components {
	using UnityEngine;
	using UnityEngine.Events;

	public class BoolEventListener : MonoBehaviour {

		[SerializeField]
		private BoolEvent @event;
		[SerializeField]
		private UnityEvent onInvokeTrue;
		[SerializeField]
		private UnityEvent onInvokeFalse;
		[SerializeField]
		private UnityEvent<bool> onInvoke;

		private void OnEnable() {
			if(@event == null) return;
			@event.OnInvoked += OnInvoked;
		}

		private void OnDisable() {
			if(@event == null) return;
			@event.OnInvoked -= OnInvoked;
		}

		private void OnInvoked(bool value) {
			if(value)
				onInvokeTrue?.Invoke();
			else
				onInvokeFalse?.Invoke();
			onInvoke?.Invoke(value);
		}
	}
}
