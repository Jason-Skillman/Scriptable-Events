namespace JasonSkillman.ScriptableEvents.Editor {
	using UnityEditor;
	using UnityEngine;
	using Event = JasonSkillman.ScriptableEvents.Event;

	[CustomEditor(typeof(Event), true)]
	public class EventEditor : Editor {
		
		private Event @event;
		
		private void OnEnable() {
			@event = target as Event;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke();
			}
		}
		
	}
}
