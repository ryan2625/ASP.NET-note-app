using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace journal_app
{
    public partial class _Default : Page
    {
        private ArrayList notes;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                notes = new ArrayList();
                Session["Notes"] = notes;
            } else
            {
                notes = (ArrayList)Session["Notes"];
            }
        }
        public void handle_add(object sender, EventArgs e)
        {
            string desc = txtName.Text;
            string name = txtDesc.Text;
            Note individualNote = new Note { Description = desc, Name = name };
            notes.Add(individualNote);
            noteRepeater.DataSource= notes;
            noteRepeater.DataBind();
            txtName.Text = "";
            txtDesc.Text = "";
        }

        public void HandleDelete(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            string deleteNote = btnDelete.CommandArgument;
            for (int i=0; i < notes.Count; i++) 
            { 
                Note note1 = (Note)notes[i];
                string test = note1.Name;
                if (test == deleteNote){
                    notes.RemoveAt(i);
                    noteRepeater.DataSource = notes;
                    noteRepeater.DataBind();
                }
            }
        }

        public class Note
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }


    }
}

//TODO: Open up a script tag in my aspx file and window.alert if txtName or txtDesc .text="". ;
//Then finish handle add by creating instance of my class, add it to arrayList, then put it in;
//a repeated in my ascx file.;