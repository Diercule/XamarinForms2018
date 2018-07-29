﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCep.Serviço.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCep.Serviço
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);


            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.camplemento == null) return null;
            return end;
        }
    }
}
