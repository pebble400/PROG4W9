using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor.Build;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class ProximityColorChangeAT : ActionTask 
	{
		public BBParameter<Transform> targetBBP;
		public BBParameter<Renderer> rendererBBP;
		public BBParameter<float> proximityBBP;

		public Color targetColor;
		private Color currentColor;

        protected override void OnExecute()
        {
			currentColor = rendererBBP.value.material.color;
        }

		protected override void OnUpdate() 
		{
			float interpolate = 1 - Vector3.Distance(targetBBP.value.position, agent.transform.position) / proximityBBP.value;

			Color colorStep = Color.Lerp(currentColor, targetColor, interpolate);
			rendererBBP.value.material.color = colorStep;
		}

        protected override void OnStop()
        {
			rendererBBP.value.material.color = currentColor;
        }
	}
}