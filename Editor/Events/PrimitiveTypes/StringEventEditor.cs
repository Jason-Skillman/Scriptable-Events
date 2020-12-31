using ScriptableEvents.Events;
using UnityEditor;
using UnityEngine;

namespace ScriptableEvents.EditorEvents {
	[CustomEditor(typeof(StringEvent), true)]
	public class StringEventEditor : Editor {
		
		private StringEvent @event;
		private string input;
		
		private void OnEnable() {
			@event = target as StringEvent;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			input = EditorGUILayout.TextField("Event Input", input);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke(input);
			}
		}
		
	}
}
