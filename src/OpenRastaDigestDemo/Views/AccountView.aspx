<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<AccountResource>" MasterPageFile="~/Views/HomeView.Master" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div>
		<h1>Your Account</h1>

		<div>
		Holder: <%= Resource.AccountHolder  %>
		</div>

		<div>
		Balance: <%= Resource.Balance %>
		</div>
    </div>
</asp:Content>
