﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dieta1
{
  public partial class Inicio : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      Response.Redirect("LoginFake.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      Response.Redirect("Alta.aspx");
    }
  }
}