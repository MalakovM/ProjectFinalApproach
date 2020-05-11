using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach
{
    public class Scene
    {
        public List<GameObject> objects = new List<GameObject>();

        public Scene()
        {

        }

        public void SetObjects(List<GameObject> objects)
        {
            this.objects = objects;
        }

        public void AddObject(GameObject item)
        {
            objects.Add(item);
            this.SetObjects(objects);
        }

        public void RemoveObject(GameObject item)
        {
            for (int i = 0; i < objects.Count; i++)
            {
                if (objects[i] == item)
                {
                    objects[i] = null;
                }
            }
            this.SetObjects(objects);
        }

        

    }
}
