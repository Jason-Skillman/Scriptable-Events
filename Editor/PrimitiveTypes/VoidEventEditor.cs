namespace JasonSkillman.ScriptableEvents.Editor {
	using UnityEditor;
	using UnityEngine;
	
	[CustomEditor(typeof(VoidEvent), true)]
	public class VoidEventEditor : Editor {
		
		private VoidEvent @event;
		
		private void OnEnable() {
			@event = target as VoidEvent;
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
