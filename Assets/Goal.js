#pragma strict

private var cleared : boolean;
//var aTexture : GUITexture;

function Start () {
	cleared = false;
}

function Update () {

}

function OnTriggerEnter ( other : Collider )
{
	if ( other.gameObject.tag == "Lob" )
	{
		if ( cleared == false )
		{
			cleared = true;
			yield WaitForSeconds(2.0);
			Application.LoadLevel("stage1");
		}
	}
}

function OnGUI()
{
	if ( cleared == true)
	{
		//GUI.DrawTexture(Rect(10,10,60,60), aTexture, ScaleMode.ScaleToFit, true, 10.0f);
	}
}