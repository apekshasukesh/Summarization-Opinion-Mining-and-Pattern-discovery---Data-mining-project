using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace drugs_symptoms_diseases
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LoadDrugs();
            }

            LoadOpinions();
        }

        //function to load all drugs
        private void LoadDrugs()
        {
            DataTable tab = new DataTable();
            BLL obj = new BLL();

            tab = obj.GetKeywordsByType("Drug");

            if (tab.Rows.Count > 0)
            {
                dropdownlistDrug.Items.Clear();

                dropdownlistDrug.DataSource = tab;
                dropdownlistDrug.DataTextField = "Keyword";
                dropdownlistDrug.DataValueField = "KeywordId";

                dropdownlistDrug.DataBind();

                dropdownlistDrug.Items.Insert(0, "All");

            }
            else
            {
                dropdownlistDrug.Items.Insert(0, "- Input Drugs-");

            }
        }
        
        //function to load all opinions
        private void LoadOpinions()
        {
            try
            {
                DataTable tab = new DataTable();
                BLL obj = new BLL();

                int totalCount = 5475;
                DateTime currentDate;
                currentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                DateTime startDate;
                startDate = currentDate.AddDays(-totalCount);

                DateTime endDate;
                endDate = currentDate.AddDays(1);

                int serialNo = 1;

                if (dropdownlistDrug.SelectedIndex > 0)
                {
                    tab = obj.GetOpinionsBydateandDrug(startDate, endDate,int.Parse(dropdownlistDrug.SelectedValue));

                }
                else
                {
                    tab = obj.GetOpinionsBydate(startDate, endDate);
                }

                if (tab.Rows.Count > 0)
                {
                    tableOpinions.Rows.Clear();

                    tableOpinions.BorderStyle = BorderStyle.Double;
                    tableOpinions.GridLines = GridLines.Both;
                    tableOpinions.BorderColor = System.Drawing.Color.DarkGray;

                    TableRow mainrow = new TableRow();
                    mainrow.HorizontalAlign = HorizontalAlign.Left;
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.Black;
                    mainrow.Font.Bold = true;
                    mainrow.BackColor = System.Drawing.Color.Goldenrod;

                    TableCell cell1 = new TableCell();
                    cell1.Text = "<b>SL No</b>";
                    mainrow.Controls.Add(cell1);

                    TableCell cell2 = new TableCell();
                    cell2.Text = "<b>Patient Name</b>";
                    mainrow.Controls.Add(cell2);

                    TableCell cell6 = new TableCell();
                    cell6.Text = "<b>Opinion</b>";
                    mainrow.Controls.Add(cell6);

                    TableCell cell7 = new TableCell();
                    cell7.Text = "<b>Date</b>";
                    mainrow.Controls.Add(cell7);

                    TableCell cell8 = new TableCell();
                    cell8.Text = "<b>Rating</b>";
                    mainrow.Controls.Add(cell8);
                                        
                    tableOpinions.Controls.Add(mainrow);

                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        TableRow row = new TableRow();
                        row.HorizontalAlign = HorizontalAlign.Left;
                        row.Height = 75;

                        TableCell cellSerialNo = new TableCell();
                        cellSerialNo.Width = 50;
                        cellSerialNo.Text = serialNo + i + ".";
                        row.Controls.Add(cellSerialNo);
                                                
                        TableCell cellName = new TableCell();
                        cellName.Width = 150;

                        string gender = null;
                        if (tab.Rows[i]["Gender"].ToString().Equals("True"))
                        {
                            gender = "Male";
                        }
                        else
                        {
                            gender = "Female";
                        }

                        cellName.Text = "<a href='#'>" + tab.Rows[i]["Name"].ToString() + "<span>Gender : " + gender + ".</br>Age : " + tab.Rows[i]["Age"].ToString() + ".</br>Address : " + tab.Rows[i]["Address"].ToString() + "</span></a>";
                        row.Controls.Add(cellName);

                        TableCell cellOpinion = new TableCell();
                        cellOpinion.Width = 750;
                        cellOpinion.Text = tab.Rows[i]["Opinion"].ToString();
                        row.Controls.Add(cellOpinion);

                        TableCell cellDate = new TableCell();
                        cellDate.Width = 100;
                        string[] s = tab.Rows[i]["PostedDate"].ToString().Split(' ');
                        cellDate.Text = s[0];
                        row.Controls.Add(cellDate);

                        TableCell cellRating = new TableCell();
                        cellRating.Width = 100;
                        cellRating.Text = tab.Rows[i]["Rating"].ToString();
                        row.Controls.Add(cellRating);
                                               
                        tableOpinions.Controls.Add(row);
                    }
                }
                else
                {
                    tableOpinions.Rows.Clear();

                    TableHeaderRow rno = new TableHeaderRow();
                    TableHeaderCell cellno = new TableHeaderCell();
                    cellno.ForeColor = System.Drawing.Color.Red;

                    if (dropdownlistDrug.SelectedIndex > 0)
                    {
                        cellno.Text = "No Opinions Found for the Drug -  " + dropdownlistDrug.SelectedItem.Text;

                    }
                    else
                    {
                        cellno.Text = "No Opinions Found";

                    }

                    rno.Controls.Add(cellno);
                    tableOpinions.Controls.Add(rno);
                }
            }
            catch
            {

            }
        }

    }
}