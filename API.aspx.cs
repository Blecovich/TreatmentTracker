﻿using DadOrganizerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DadOrganizer
{
    public partial class API : System.Web.UI.Page
    {
        ScheduleRepo scheduler = new ScheduleRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"] == "administer")
            {
                try
                {
                    Response.Write(AdministerTreatment(Convert.ToInt32((Request.QueryString["id"]))));
                }
                catch (Exception exc)
                {
                    Response.Write(exc.Message);
                }
            }
        }

        protected string AdministerTreatment(int id)
        {
            try
            {
                scheduler.AdministerTreatment(id);  
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Success";
        }
    }
}