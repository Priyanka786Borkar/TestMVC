using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMVC.Data;

namespace TestMVC.Models.TestMVC
{
    public class TestMVCModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public string SaveTestMVC(TestMVCModel model)
        {
            string msg = "";
            TestMVCEntities db = new TestMVCEntities();
            var SaveTestMVC = new tblTest()
            {
                Name = model.Name,
                Age = model.Age,
            };
            db.tblTests.Add(SaveTestMVC);
            db.SaveChanges();
            return msg;
        }
    }
    
}