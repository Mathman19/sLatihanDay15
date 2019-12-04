using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using clXPos.DataModel;
using System.Linq;

namespace waDay15Xpos.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCategoryEntity()
        {
            Trace.WriteLine("-- Start Read Category --");
            using (var db = new XPosContext())
            {
                var listCategory = db.Categories.ToList();
            }
            Trace.WriteLine("-- End Read Category --");
        }

        [TestMethod]
        public void TestInsertCategory()
        {
            Trace.WriteLine("-- Start Insert Category --");
            using (var db = new XPosContext())
            {
                //var listCategory = db.Categories.ToList();
                Category category = new Category();
                category.Initial = "ManCo";
                category.Name = "Main Course";
                category.Active = true;
                category.CreatedBy = "Atur";
                category.CreatedDate = DateTime.Now;

                db.Categories.Add(category);
                db.SaveChanges();
            }
            Trace.WriteLine("-- End Insert Category --");
        }

        //Create
        [TestMethod]
        public void TestInsertVariant()
        {
            Trace.WriteLine("-- Start Insert Variant --");
            using (var db = new XPosContext())
            {
                //var listCategory = db.Categories.ToList();
                Variant variant = new Variant();
                variant.CategoryId = 1;
                variant.Initial = "DSR";
                variant.Name = "Desert";
                variant.Active = true;
                variant.CreatedBy = "Atur";
                variant.CreatedDate = DateTime.Now;

                db.Variants.Add(variant);
                db.SaveChanges();
            }
            Trace.WriteLine("-- End Insert Variant --");
        }

        //Read
        [TestMethod]
        public void TestSelectVariantById()
        {
            Trace.WriteLine("-- Select Variant By Id--");
            using (var db = new XPosContext())
            {                
                Variant variant = db.Variants.Where(v => v.Id == 1).FirstOrDefault();
                Trace.WriteLine(variant.Initial + " " + variant.Name);
            }
            Trace.WriteLine("-- Select Variant By Id --");
        }
    }
}

