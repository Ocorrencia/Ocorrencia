using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUTRIPLAN_WEB.MVC_4_BS.Business;
using NUTRIPLAN_WEB.MVC_4_BS.Model.Models;


namespace NWORKFLOW_WEB.MVC_4_BS.Models
{
    public class ListaN0204PPU
    {
        public long? codigo { get; set; }
        public string descricao { get; set; }
        public string usuaprovador { get; set; }

        public static explicit operator ListaN0204PPU(N0204PPU N0204PPU)
        {
            ListaN0204PPU item = new ListaN0204PPU();
            if (N0204PPU.USUDEP == null || N0204PPU.USUDEP == 0) 
            {
                if (N0204PPU.CODUSU.HasValue) 
                { 
                    var ActiveDirectoryBusiness = new ActiveDirectoryBusiness();
                    var N9999USUBusiness = new N9999USUBusiness();
                    var dadosusuariodependente = N9999USUBusiness.ListaDadosUsuarioPorCodigo((int)N0204PPU.CODUSU);
                    var usuariodependente = ActiveDirectoryBusiness.ListaDadosUsuarioAD(dadosusuariodependente.LOGIN);
                    item.usuaprovador = usuariodependente.Nome;
                    item.codigo = N0204PPU.CODUSU;
                    item.descricao = usuariodependente.Nome;
                }
            }
            return item;
        }
    }
}