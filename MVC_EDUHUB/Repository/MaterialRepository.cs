using System.Collections.Generic;
using System.Linq;
using MVC_Eduhub;
using MVC_EDUHUB.Models;
 
namespace MVC_EDUHUB
{
    public class MaterialRepository : IMaterialService
    {
        private readonly AppDbContext _context;
        public MaterialRepository(AppDbContext context)
        {
            _context=context;
        }
        public void CreateMaterial(Material newMaterial, int courseid)
        {
            newMaterial.CourseId=courseid;
            _context.Materials.Add(newMaterial);
        }
 
        public IEnumerable<Material> GetAllMaterials()
        {
            var data=_context.Materials;
            return data;
        }
 
        public IEnumerable<Material> GetMaterialByCourseId(int courseId)
        {
            var data=_context.Materials.Where(x=>x.CourseId==courseId);
            return data;
        }
 
        public Material GetMaterialByMaterialId(int id){
            var data=_context.Materials.FirstOrDefault(x=>x.MaterialId==id);
            return data;
        }
        public void UpdateMaterial(int materialId, Material material)
        {
            var data=this.GetMaterialByMaterialId(materialId);
            // data.MaterialId=material.MaterialId;
            // data.Title=material.Title;
            data.Description=material.Description;
            data.CourseId=material.CourseId;
            data.URL=material.URL;
            data.UploadDate=material.UploadDate;
            data.ContentType=material.ContentType;
            _context.Materials.Update(data);
            _context.SaveChanges();
        }
        public void Delete(int id){
            var data=this.GetMaterialByMaterialId(id);
            _context.Materials.Remove(data);
            _context.SaveChanges();
        }
 
        public void Create(Material newMaterial){
            _context.Materials.Add(newMaterial);
                _context.SaveChangesAsync();
        }
    }
}