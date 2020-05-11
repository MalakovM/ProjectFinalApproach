using System.Collections.Generic;

namespace GXPEngine.ProjectFinalApproach
{
    /// <summary>
    /// Scene class that has all content in a list
    /// </summary>
    public class Scene
    {
        // Init objects list
        public List<GameObject> objects = new List<GameObject>();

        public Scene()
        {

        }

        /// <summary>
        /// Set objects to list
        /// </summary>
        /// <param name="objects"> Scene objects list </param>
        public void SetObjects(List<GameObject> objects)
        {
            this.objects = objects;
        }

        /// <summary>
        /// Add an object to objects list
        /// </summary>
        /// <param name="item"> An object  </param>
        public void AddObject(GameObject item)
        {
            objects.Add(item);
            this.SetObjects(objects);
        }

        /// <summary>
        /// Remove an object from object list
        /// </summary>
        /// <param name="item"> An object </param>
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
