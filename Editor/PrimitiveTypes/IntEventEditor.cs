namespace JasonSkillman.ScriptableEvents.Editor {
	using UnityEditor;
	using UnityEngine;
	
	[CustomEditor(typeof(IntEvent), true)]
	public class IntEventEditor : Editor {
		
		private IntEvent @event;
		private int input;
		
		private void OnEnable() {
			@event = target as IntEvent;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			input = EditorGUILayout.IntField("Event Input", input);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke(input);
			}
		}
		
	}
}
