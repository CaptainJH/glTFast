using UnityEngine;

namespace GLTFast.Schema
{

    [System.Serializable]
    public class BoxColliderData
    {

        [System.Serializable]
        public class Attributes
        {
            public Vector3 Center = Vector3.zero;
            public Vector3 Size = Vector3.zero;
        }

        public Attributes attributes = new Attributes();

        public void GltfSerialize(JsonWriter writer)
        {
            writer.AddObject();
            {
                writer.AddProperty("attributes");
                writer.AddObject();
                {
                    writer.AddProperty("Center");
                    writer.AddObject();
                    {
                        writer.AddProperty("x", attributes.Center.x);
                        writer.AddProperty("y", attributes.Center.y);
                        writer.AddProperty("z", attributes.Center.z);
                    }
                    writer.Close();

                    writer.AddProperty("Size");
                    writer.AddObject();
                    {
                        writer.AddProperty("x", attributes.Size.x);
                        writer.AddProperty("y", attributes.Size.y);
                        writer.AddProperty("z", attributes.Size.z);
                    }
                    writer.Close();
                }
                writer.Close();

            }
            writer.Close();
        }

    }
}