using UnityEngine;
using GLTFast;
public class RuntimeGlb : MonoBehaviour
{
    public string path;
    GltfImport importer;
    async void Start(){try{if(!System.IO.File.Exists(path))throw new System.IO.FileNotFoundException(path);
     importer=new GltfImport();bool ok=await importer.Load(new System.Uri(System.IO.Path.GetFullPath(path)).AbsoluteUri);
     if(!ok||!await importer.InstantiateMainSceneAsync(transform))Debug.LogError("GLB import failed");}
     catch(System.Exception e){Debug.LogError(e.Message);}}
    // Keep importer alive while instantiated meshes/materials are used. Only destroy after loading completes.
    void OnDestroy(){importer?.Dispose();}
}
