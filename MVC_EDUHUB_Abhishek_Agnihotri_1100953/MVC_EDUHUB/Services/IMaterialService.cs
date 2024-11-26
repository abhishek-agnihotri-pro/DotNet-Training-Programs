using System.Collections;
using System.Collections.Generic;
using MVC_EDUHUB.Models;
 
namespace MVC_Eduhub
{
    public interface IMaterialService
    {
        IEnumerable<Material> GetAllMaterials();
        IEnumerable<Material> GetMaterialByCourseId(int courseId);
 
        Material GetMaterialByMaterialId(int id);
        void CreateMaterial(Material newMaterial,int courseid);
 
        void UpdateMaterial(int materialId,Material material);
 
        void Delete(int materialId);
 
        void Create(Material newMaterial);
    }
}