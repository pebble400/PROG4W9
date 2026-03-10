using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class ColorChangeAT : ActionTask 
	{
		public BBParameter<Renderer> renderer;
		public Color color = Color.white;

		protected override void OnExecute() 
		{
			renderer.value.material.color = color;
			EndAction(true);
		}
	}
}