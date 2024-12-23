using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Btap1WA.Models;

namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class DanhsachNYCControlller : ControllerBase
    {
        dsnycC dbc;

        public DanhsachNYCControlller(dsnycC db)
        {
            dbc = db;
        }
        [HttpGet]
        [Route("/DanhsachNYC_AKIEN/List")]
        public IActionResult GetList()
        {
            return Ok(new {data = dbc.Dsnycs.ToList()});
        }
        [HttpPost]
        [Route("/DanhsachNYC_AKIEN/Insert")]
        public IActionResult Them(int stt,string ten, string namsinh, string diachi, string tel)
        {
            Dsnyc hh = new Dsnyc();
            hh.Stt = stt;
            hh.Ten=ten;
            hh.Namsinh=namsinh;
            hh.Diachi=diachi;
            hh.Tel=tel;
            dbc.Dsnycs.Add(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
        [HttpPost]
        [Route("/DanhsachNYC_AKIEN/Update")]
        public IActionResult Update(int stt, string ten, string namsinh, string diachi, string tel)
        {
            Dsnyc hh = new Dsnyc();
            hh.Stt= stt;
            hh.Ten=ten;
            hh.Namsinh=namsinh;
            hh.Diachi=diachi;
            hh.Tel=tel;
            dbc.Dsnycs.Update(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
        [HttpDelete]
        [Route("/DanhsachNYC_AKIEN/Delete")]
        public IActionResult Xoa(int stt)
        {
            Dsnyc hh = new Dsnyc();
            hh.Stt= stt;
            dbc.Dsnycs.Remove(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
    }
}
