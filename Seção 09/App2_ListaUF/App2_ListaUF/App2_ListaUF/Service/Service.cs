using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App2_ListaUF.Model;
using Newtonsoft.Json;

namespace App2_ListaUF.Service
{
    public class Service
    {
        private static string URLEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URLMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/microrregioes";
        public static List<Estado> getEstados()
        {
            WebClient wc = new WebClient();
            string conteudo =  wc.DownloadString(URLEstado);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);

        }

        public static List<Municipio> getMunicipio(int estado)
        {
            string NewURL = string.Format(URLMunicipio, estado);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NewURL);

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);

        }
    }
}
