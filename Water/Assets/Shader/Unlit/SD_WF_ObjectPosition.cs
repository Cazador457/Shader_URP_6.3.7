using UnityEngine;

public class SD_WF_ObjectPosition : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        ShaderWaterFall();
    }
    public void ShaderWaterFall()
    {
        Shader.SetGlobalVector("_ObjectPosition", new Vector4(this.transform.position.x, this.transform.position.y, this.transform.position.z, this.transform.localScale.x));
    }
}
