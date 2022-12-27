namespace JasonSkillman.ScriptableEvents.Components {
    using UnityEngine;
    using UnityEngine.Events;

    public class EventInvoker : MonoBehaviour {

        [SerializeField]
        private VoidEvent @event;
        [SerializeField]
        private UnityEvent onInvoke;

        [ContextMenu("Invoke")]
        public void Invoke() => @event.Invoke();

        private void OnEnable() => @event.OnInvoked += OnInvoked;
        
        private void OnDisable() => @event.OnInvoked -= OnInvoked;

        private void OnInvoked() => onInvoke.Invoke();
    }
}
