using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(EnableSession = true)]
    public bool AddRepo(Repo repo)
    {
        List<Repo> repos;
        if (Session["Bookmarks"] != null)
        {
            repos = (List<Repo>)Session["Bookmarks"];
        }
        else
        {
            repos = new List<Repo>();
        }

        repos.Add(repo);
        Session["Bookmarks"] = repos;

        return true;
    }
    [WebMethod(EnableSession = true)]
    public List<Repo> GetBookmarks()
    {
        List<Repo> repos;
        if (Session["Bookmarks"] != null)
        {
            repos = (List<Repo>)Session["Bookmarks"];
        }
        else
        {
            repos = new List<Repo>();
        }



        return repos;
    }

}
