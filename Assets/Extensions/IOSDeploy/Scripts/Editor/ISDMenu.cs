using UnityEngine;
using System.Collections;
using UnityEditor;

public class ISDMenu : EditorWindow
{
#if UNITY_EDITOR
	[MenuItem("Window/IOS Deploy")]
	public static void Edit() {
		Selection.activeObject = ISDSettings.Instance;
	}
#endif
}
