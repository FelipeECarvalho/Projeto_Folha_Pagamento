using Microsoft.AspNetCore.Mvc;
using Modelo;
using Servico;

namespace Projeto_Web.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            var acesso = new Acesso();
            return View(acesso);
        }

        [HttpGet]<div class="ytp-cued-thumbnail-overlay" data-layer="4" style="margin: 0px; padding: 0px; border: 0px; background: center center / cover no-repeat transparent; position: absolute; width: 1271.11px; height: 714.984px; top: 0px; left: 0px; transition: opacity 0.25s cubic-bezier(0, 0, 0.2, 1) 0s; cursor: pointer; color: rgb(238, 238, 238); font-family: &quot;YouTube Noto&quot;, Roboto, Arial, Helvetica, sans-serif; font-size: 11px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"><br class="Apple-interchange-newline"><div class="ytp-cued-thumbnail-overlay-image" style="margin: 0px; padding: 0px; border: 0px; background: url(&quot;https://i.ytimg.com/vi/u4lcUooNNLY/maxresdefault.jpg?sqp=-oaymwEmCIAKENAF8quKqQMa8AEB-AH-CYAC0AWKAgwIABABGC8gUih_MA8=&amp;rs=AOn4CLDQFZvBFwJxJpxzvqWWVgAd_Xhi9Q&quot;) center center / cover no-repeat transparent; width: 1271.11px; height: 714.984px; position: absolute;"></div><button class="ytp-large-play-button ytp-button" aria-label="Reproduzir" title="Reproduzir" style="border: none; background-color: transparent; padding: 0px; color: inherit; text-align: inherit; font-size: 11px; font-family: inherit; cursor: pointer; line-height: inherit; outline: 0px; position: absolute; left: 635.547px; top: 357.484px; width: 68px; height: 48px; margin-left: -34px; margin-top: -24px; transition: opacity 0.25s cubic-bezier(0, 0, 0.2, 1) 0s; z-index: 63;"><svg height="100%" version="1.1" viewBox="0 0 68 48" width="100%"><path class="ytp-large-play-button-bg" d="M66.52,7.74c-0.78-2.93-2.49-5.41-5.42-6.19C55.79,.13,34,0,34,0S12.21,.13,6.9,1.55 C3.97,2.33,2.27,4.81,1.48,7.74C0.06,13.05,0,24,0,24s0.06,10.95,1.48,16.26c0.78,2.93,2.49,5.41,5.42,6.19 C12.21,47.87,34,48,34,48s21.79-0.13,27.1-1.55c2.93-0.78,4.64-3.26,5.42-6.19C67.94,34.95,68,24,68,24S67.94,13.05,66.52,7.74z" fill="#f00"></path><path d="M 45,24 27,14 27,34" fill="#fff"></path></svg></button></div><div class="ytp-paid-content-overlay" aria-live="assertive" aria-atomic="true" data-layer="4" style="margin: 0px; padding: 0px; border: 0px; background: transparent; border-radius: 0px; inset: 16px auto auto 16px; display: inline-block; font-size: 12px; height: auto; line-height: 30px; overflow: hidden; pointer-events: auto; position: absolute; text-shadow: rgba(0, 0, 0, 0.5) 0px 0px 2px; z-index: 27; font-weight: 400; color: rgb(238, 238, 238); font-family: &quot;YouTube Noto&quot;, Roboto, Arial, Helvetica, sans-serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"></div><br class="Apple-interchange-newline">
        public IActionResult Acessar(Acesso acesso)
        {
            try
            {
                var acessoServico = new AcessoServico();
                var acessoBd = acessoServico.BuscarAcesso(acesso.Usuario, acesso.SenhaOriginal);

                return RedirectToAction("Index", "Menu", new { id = acessoBd.Colaborador.Id });
            } 
            catch (Exception ex) 
            {
                ViewBag.Mensagem = ex.Message;

                return View("Index");
            }
        }
    }
}