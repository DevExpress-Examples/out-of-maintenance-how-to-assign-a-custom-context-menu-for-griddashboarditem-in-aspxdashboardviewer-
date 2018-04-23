using System;
using NewProject;
using System.Linq;
using System.Collections.Generic;
using DevExpress.DashboardCommon;
using DevExpress.Web;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ASPxDashboardViewer1_DataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e)
        {
            List<MyClass> list = CreateDataSource();
            e.Data = list;
        }

        private static List<MyClass> CreateDataSource()
        {
            List<MyClass> list = new List<MyClass>(10);
            Random _r = new Random();
            for (int i = 0; i < 10; i++)
                list.Add(new MyClass() { ID = i, Name = "Name" + i, Sales = (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i) });
            return list;
        }
    }
}