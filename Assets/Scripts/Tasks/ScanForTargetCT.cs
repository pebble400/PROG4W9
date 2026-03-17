using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class ScanForTargetCT : ConditionTask
	{
		public BBParameter<Collider[]> nearbyTargets;
		public BBParameter<int> numberOfTargets;
		public BBParameter<float> scanRadius;
		public BBParameter<LayerMask> scanLayers;
		
		protected override bool OnCheck()
		{
			numberOfTargets.value = Physics.OverlapSphereNonAlloc(agent.transform.position, scanRadius.value, nearbyTargets.value, scanLayers.value);

			if (numberOfTargets.value > 0 )
			{
                return true;
            }
			else
			{
				return false;
			}
		}
	}
}