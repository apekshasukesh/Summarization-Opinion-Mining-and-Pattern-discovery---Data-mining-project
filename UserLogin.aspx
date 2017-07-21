<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterpage.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="drugs_symptoms_diseases.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="panelUserLogin" runat="server">

    
<div class="ser-main">
		<div class="header_02">Login form!!! (Administrator/Medical Practitioners)</div>

        
					     <div class="contact-form">
			 	
					    <form method="post" action="contact-post.html">
                            <div>
						    	<span><label>User Type</label></span>
						    	<span>
                                    <asp:DropDownList ID="dropdownlistType" runat="server" Height="25px" 
                                    Width="40%">
                                        <asp:ListItem>Select</asp:ListItem>
                                        <asp:ListItem>Administrator</asp:ListItem>
                                        <asp:ListItem>Medical Practitioner</asp:ListItem>
                                    </asp:DropDownList>
                                    <br /> 
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="dropdownlistType" CssClass="validation" 
                                    ErrorMessage="Select UserType" Operator="NotEqual" ToolTip="Select UserType" 
                                    ValidationGroup="login" ValueToCompare="Select"></asp:CompareValidator>
                                </span>
						    </div>
					    	<div>
						    	<span><label>Login Id</label></span>
						    	<span>
                                    <asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Enter LoginId" ControlToValidate="txtLoginId" 
                                    ToolTip="Enter LoginId" ValidationGroup="login" CssClass="validation"></asp:RequiredFieldValidator></span>
						    </div>
						    <div>
						    	<span><label>Password</label></span>
						    	<span><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="480px" Height="30px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="Enter Password" ControlToValidate="txtPassword" 
                                    ToolTip="Enter Password" ValidationGroup="login" CssClass="validation"></asp:RequiredFieldValidator></span>
						    </div>
						   
						   <div>
						   		<span>
                                       <asp:Button ID="btnLogin" runat="server" Text="Submit" 
                                    ValidationGroup="login" onclick="btnLogin_Click" /></span>
						  </div>
					    </form>
				    </div>
  				<div class="clear"> </div>		
			  </div>
    </asp:Panel>



</asp:Content>
