<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterpage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="drugs_symptoms_diseases.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelIndex" runat="server">

 
    
<div class="ser-main">
		<div class="header_02">View Patients Opinions [Past 15 years]!!!</div>

        
					     <div class="contact-form">
			 	
					    <form method="post" action="contact-post.html">
                            
					    	 <div>
						    	<span><label>Select Drug</label></span>
						    	<span>
                                    <asp:DropDownList ID="dropdownlistDrug" runat="server" Height="25px" 
                                    Width="40%" 
                                    AutoPostBack="True">
                                      
                                    </asp:DropDownList> 
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="dropdownlistDrug" CssClass="validation" 
                                    ErrorMessage="Select Drug" Operator="NotEqual" ToolTip="Select Drug" 
                                    ValidationGroup="key" ValueToCompare="Select"></asp:CompareValidator>
                                </span>
						    </div>
					    	
						 
						   
						   <div>
						  </div>

                           <div>
						   		<span>
                                     <div class="header_02">View Opinions</div> </span>
						  </div>

                            <div>
                             <div id="popup">
						   		<span>
                                
                                       <asp:Table ID="tableOpinions" runat="server">
                                       </asp:Table>  </span>
                                       </div>
                                       
						  </div>
                          

					    </form>
				    </div>
  				<div class="clear"> </div>		
			  </div>


    </asp:Panel>

</asp:Content>
