using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ChangeColorRandomAT : ActionTask {
        public class ColorChangeAT : ActionTask
        {
            public BBParameter<Renderer> renderer;
            public Color color = Color.white;

            protected override void OnExecute()
            {
                renderer.value.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
                EndAction(true);
            }
        }
    }
}