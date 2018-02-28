using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GmailScriptable", menuName = "MessageScriptable")]
public class Gmail : ScriptableObject {

	public string name;
	public string objet;
	public string infoMessage;
	public string corpsMessage;

}
