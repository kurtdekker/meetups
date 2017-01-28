using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChannelSelector : MonoBehaviour
{
	int currentChannel;

	public Text TextCurrentChannel;

	void UpdateTextCurrentChannel()
	{
		TextCurrentChannel.text = "Current Channel: " + currentChannel.ToString ();
	}

	public void ChangeChannel( int direction)
	{
		currentChannel += direction;

		UpdateTextCurrentChannel ();
	}

	void Start ()
	{
		UpdateTextCurrentChannel ();
	}
}
