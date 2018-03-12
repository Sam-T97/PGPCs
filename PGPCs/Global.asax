<%@ Application Language="C#" %>
<%@ Import Namespace="PGPCs" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Data.Entity" %>
<%@ Import Namespace="PGPCs.Models" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);

        //Build the database
        Database.SetInitializer(new DbInit());
    }

</script>
