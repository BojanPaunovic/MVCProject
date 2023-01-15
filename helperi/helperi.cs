using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjekatPSA.helperi
{
    public static class Helperi
    {
        public static MvcHtmlString popustHelper(double cena, double popust)
        {
            var tag = new TagBuilder("div");
            double cenaSaPopustom = 0;

            if(popust!=0)
            {
                cenaSaPopustom = cena - (cena * popust / 100);
                tag.AddCssClass("popust");
                tag.InnerHtml = "<h4>" + cena + " din. </h4>" +
                                "<h2>" + cenaSaPopustom + " din. </h2>";
            }
            else
            {
                tag.InnerHtml = "<h2>" + cena + " din. </h2>";
            }

            return new MvcHtmlString(tag.ToString());
        }
    }
}