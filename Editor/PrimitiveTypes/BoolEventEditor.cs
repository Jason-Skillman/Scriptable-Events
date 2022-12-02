namespace JasonSkillman.ScriptableEvents.Editor {
	using UnityEditor;
	using UnityEngine;
	
	[CustomEditor(typeof(BoolEvent), true)]
	public class BoolEventEditor : Editor {
		
		private BoolEvent @event;
		private bool input;
		
		private void OnEnable() {
			@event = target as BoolEvent;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			input = EditorGUILayout.Toggle("Event Input", input);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke(input);
			}
		}
		
	}
}
