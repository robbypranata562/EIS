using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EIS.Class;
using EIS.Model;
using EIS.Controller;
using EIS.Properties;
using Z80NavBarControl.Z80NavBar.Themes;
using Z80NavBarControl.Z80NavBar;
namespace EIS.Controller
{
    class DashboardController
    {
        DashboardClass DC = new DashboardClass();
        MenuModel DM = new MenuModel();
        List<NavBarItem> sample2 = new List<NavBarItem>();
        List<NavBarItem> sample3;
        NavBarItem Item;// = new NavBarItem();
        NavBarItem ItemChild;// = new NavBarItem();
        //int[] a = new int[200];
        List<NavBarItem>[] arr = new List<NavBarItem>[50];
        public List<NavBarItem> generateMenu () {
           
            var ret = DC.GenerateMenu();
            //ItemChild.Add(new NavBarItem { ID = 2005, Text = "Child Dshboard", ParentID = 1 });
            
            //arr[0] = ItemChild;
            //var a = arr[0].FirstOrDefault().ParentID;
           // arr[0].FirstOrDefault().ParentID)
            //get child
            //for (var i = 0; i < ret.Count; i++)
            //{
            //    if (ret[i].parent != "0")
            //    {
            //        ItemChild.Add(new NavBarItem { ID = Convert.ToInt32(ret[i].t_menu_id), Text = ret[i].menu_name, ParentID = Convert.ToInt32(ret[i].parent) });
            //    }
            //}
            //
            for (var i = 0; i < ret.Count; i++)
            {
                var retChild = DC.GenerateMenuChild(ret[i].t_menu_id);
                for (var j = 0; j < retChild.Count; j++)
                {
                    if (retChild[j].parent != "0")
                    {
                        //ItemChild.Add(new NavBarItem 
                        //{ 
                        //    ID = Convert.ToInt32(retChild[j].t_menu_id), 
                        //    Text = retChild[j].menu_name, 
                        //    ParentID = Convert.ToInt32(retChild[j].parent) 
                        //}
                        //);
                            ItemChild.ID = Convert.ToInt32(retChild[j].t_menu_id);
                            ItemChild.Text = retChild[j].menu_name;
                            ItemChild.ParentID = Convert.ToInt32(retChild[j].parent);
                    }
                }
                sample2.Add(new NavBarItem 
                { 
                    ID = Convert.ToInt32(ret[i].t_menu_id), 
                    Text = ret[i].menu_name,
                    Childs = new List<NavBarItem> 
                    {
                        ItemChild
                    }
                });

            }
                return sample2;
        }

        public List<NavBarItem> generateMenu(string ex)
        {
            sample2 = new List<NavBarItem> {
            new NavBarItem {ID = 1, Text = "Desktop",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 1001, ParentID = 1, Text = "Start",Height = 30},
                    new NavBarItem {ID = 1002, ParentID = 1, Text = "My comments", Height = 30},
                    new NavBarItem {ID = 1003, ParentID = 1, Text = "Site Statistics", Height = 30},
                    new NavBarItem {ID = 1004, ParentID = 1, Text = "My blogs", Height = 30},
                    new NavBarItem {ID = 1005, ParentID = 1, Text = "Blogs I follow", Height = 30},
                    new NavBarItem {ID = 1006, ParentID = 1, Text = "Akismed statistics", Height = 30},
                    new NavBarItem {ID = 1007, ParentID = 1, Text = "Omnisearch", Height = 30},
                    new NavBarItem {ID = 2003, ParentID = 2, Text = "My domains", Height = 30},
                    new NavBarItem {ID = 2004, ParentID = 2, Text = "Manage purchases", Height = 30},
                    new NavBarItem {ID = 2005, ParentID = 2, Text = "Billing history", Height = 30}
                }
            },
            new NavBarItem {ID = 2, Text = "Store",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 2001, ParentID = 2, Text = "Main", Height = 30},
                    new NavBarItem {ID = 2002, ParentID = 2, Text = "Premium Themes", Height = 30},

                }
            },
           
        };
            return sample2;
        }
      
    }
}
