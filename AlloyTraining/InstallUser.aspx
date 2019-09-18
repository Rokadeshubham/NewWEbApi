<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstallUser.aspx.cs" Inherits="AlloyTraining.InstallUser" %>

<% try
    {
        //Roles.CreateRole("Administrators");
        //Roles.CreateRole("WebEditor");
        //Roles.CreateRole("WebVerifier");
    }
    catch (Exception)
    {
    }
    try
    {
        var user = Membership.CreateUser("subham", "subham", "subham@episerver.com");
        user.IsApproved = true;
    }
    catch (Exception ex)
    {
        string value = ex.Message;
    }

    try
    {
        Roles.AddUserToRole("subham", "Administrators");

    }
    catch (Exception) { }


%>
