using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Birds_Of_A_Feather
{
    abstract class StationaryObject : SceneObject
    {
        public static new List<StationaryObject> activeObjects = new List<StationaryObject>();

        public StationaryObject(Vector _position)
            : base(_position)
        {
            activeObjects.Add(this);
        }

        public StationaryObject()
        {
            activeObjects.Add(this);
        }

        public override void Draw(Color colour)
        {
            GL.Begin(PrimitiveType.Polygon);
            for (int vertexIndex = 0; vertexIndex < this.vertices.Length; vertexIndex++)
            {
                Vector vertexVector = Vector.Add(this.position, this.relativeVertices[vertexIndex]);
                GL.Color3(colour);
                GL.Vertex2(vertexVector.x, vertexVector.y);
            }
            GL.End();
        }

        public override T[] GetNearbyObjects<T>(List<T> group, double radius, double angle = (2 * Math.PI))
        {
            List<T> nearbyObjectsList = new List<T>();
            T[] nearbyObjects;
            foreach (T member in group)
            {
                if (WithinRange(member, radius) && member != this)
                {
                    nearbyObjectsList.Add(member);
                }
            }
            nearbyObjects = nearbyObjectsList.ToArray<T>();
            return nearbyObjects;
        }

        public override void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
            base.RemoveObjectFromScene();
        }
    }
}