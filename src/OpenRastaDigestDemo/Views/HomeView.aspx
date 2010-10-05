<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<HomeResource>"
	MasterPageFile="~/Views/HomeView.Master" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
	<div>
		Welcome home.
	</div>
	<div>
		<div>
			Three user's are supported:
			<table>
				<thead>
					<tr>
						<th>
							Username
						</th>
						<th>
							Password
						</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>
							fred
						</td>
						<td>
							fred-pass
						</td>
					</tr>
					<tr>
						<td>
							david
						</td>
						<td>
							david-pass
						</td>
					</tr>
					<tr>
						<td>
							bob
						</td>
						<td>
							bob-pass
						</td>
					</tr>
				</tbody>
			</table>
		</div>
		<a href="/my-account">View Your Account</a>
	</div>
</asp:Content>
