using ScriptableEvents.Events;
using UnityEditor;
using UnityEngine;

namespace ScriptableEvents.EditorEvents {
	[CustomEditor(typeof(DoubleEvent), true)]
	public class DoubleEventEditor : Editor {
		
		private DoubleEvent @event;
		private double input;
		
		private void OnEnable() {
			@event = target as DoubleEvent;
		}
		
		public override void OnInspectorGUI() {
			//base.OnInspectorGUI();
			
			EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

			input = EditorGUILayout.DoubleField("Event Input", input);

			if(GUILayout.Button("Invoke")) {
				@event.Invoke(input);
			}
		}
		
	}
}
