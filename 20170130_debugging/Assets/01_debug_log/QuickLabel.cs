using UnityEngine;
using System.Collections;

public class QuickLabel : MonoBehaviour
{
	static int MasterCounter;

	const float LabelWidth = 200;
	const float LabelHeight = 50;

	string title;
	System.Func<string> GetData;
	int index;

	public static QuickLabel Create(
		string title,
		System.Func<string> GetData)
	{
		QuickLabel ql = new GameObject ("QuickLabel:" + title).AddComponent<QuickLabel> ();
		ql.title = title;
		ql.GetData = GetData;
		ql.index = MasterCounter;
		MasterCounter++;
		return ql;
	}

	void OnGUI()
	{
		GUI.Label (new Rect (0, index * LabelHeight, LabelWidth, LabelHeight),
		          title + GetData ());
	}
}
