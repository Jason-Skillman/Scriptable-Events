namespace JasonSkillman.ScriptableEvents.Editor {
	using UnityEditor;
	using UnityEngine;
	
	[CustomEditor(typeof(FloatEvent), true)]
	public class FloatEventEditor : Editor {
		
		private FloatEvent @event;
		private float input;
		
		private void OnEnable() {
			@event = target as FloatEvent;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			input = EditorGUILayout.FloatField("Event Input", input);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke(input);
			}
		}
		
	}
}
