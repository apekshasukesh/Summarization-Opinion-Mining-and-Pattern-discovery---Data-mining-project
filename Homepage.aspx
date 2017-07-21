<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterpage.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="drugs_symptoms_diseases.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelIndex" runat="server">

 
    
<div class="ser-main">
		<div class="header_02">Welcome Guest!!!</div>

        
					     <div class="contact-form">
			 	
						 <p>
                         For a disease, one(doctor) should give the proper treatment for the patient. As multiple drugs are available for the particular disease, there is need of identifying the popular drug. As symptoms are related to disease and diseases are related to drugs, there is a need for the system which discovers the relationship between symptoms-diseases-drugs. 
                         </p>
                         <br />
						 <p>
                         In the proposed system we are achieving this based on the patient opinions. 
                         </p>
                         <br />
                         <p>
                         Performing summarization of user posts per drug, and come out with useful conclusions for medical fraternity as well as patient community is a important factor in medical sector.
                         </p>
                         <br />
						 <p>
                         Proposed system collects real time health posts from reputed websites, where patients express their views, including their experiences and side-effects on drugs used by them. Proposed system perform Summarization of user posts per drug, and come out with useful conclusions for medical fraternity as well as patient community at a glance. Also, proposed system perform knowledge discovery from user posts, whereby useful `patterns' about the triad `drugs-symptoms-medicine' is done by Association Rule Mining. 
                         </p>  
						   <div>
						  </div>

                            <div>
                                       
						  </div>
                          

					  
				    </div>
  				<div class="clear"> </div>		
			  </div>


    </asp:Panel>


</asp:Content>
