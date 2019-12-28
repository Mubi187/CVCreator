using CVeator.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeatorServices;
using SelectPdf;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;

namespace CVeator.Web.Controllers
{
    public class CVsViewController : Controller
    {
        PersonalInfo personalInfo=new PersonalInfo();
        CVsServices cVsServices = new CVsServices();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CV1(int ID)
        {
            CVPreview model = new CVPreview();
            model.CV = cVsServices.GetCVById(ID);
            
            return PartialView(model);
        }
        public ActionResult Preview()
        {
            return View();
        }
        public ActionResult CVPrint(string name, int id)
        {
            //HtmlToPdf toPdf = new HtmlToPdf();
           
            return RedirectToAction("htmltopdf", "CVsView", new { Name = name, ID = id });
        }
        public ActionResult htmltopdf(string name, int id)
        {

            HtmlToPdf converter = new HtmlToPdf();
            // set converter options
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

            converter.Options.WebPageWidth = 1024;
            converter.Options.WebPageHeight = 0;
            converter.Options.WebPageFixedSize = false;

            converter.Options.AutoFitWidth = HtmlToPdfPageFitMode.ShrinkOnly;
            converter.Options.AutoFitHeight = HtmlToPdfPageFitMode.NoAdjustment;
            converter.Options.MarginTop = 10;
            converter.Options.MarginBottom = 20;
            converter.Options.MarginLeft = 10;
            converter.Options.MarginRight = 10;


            PdfDocument doc = new PdfDocument();

            doc = converter.ConvertUrl("https://localhost:44385/cvsview/cv1/"+id);

            var filename = name + id + ".pdf";
            string fileName = Server.MapPath(@"~/Content/CV pdf/" + filename);

           // var filename = Guid.NewGuid() + Path.GetExtension(picture.FileName);
           //var path = Server.MapPath("~/Content/images/") + filename;
            //picture.SaveAs(path);

            doc.Save(fileName);
            doc.Close();
            return RedirectToAction("DownloadFile", "CVsView", new { name = filename });
            
        }
        public FileResult DownloadFile(string name)
        {
            string path = Server.MapPath("~/Content/CV pdf");
            string file = Path.GetFileName(name);
            string fullpath = Path.Combine(path, file);
            
            return File(fullpath, "application/pdf",name);

        }
    }
}