using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using NossoChat.Model;
using Newtonsoft.Json;

namespace NossoChat.Service
{
    public class ServiceWS
    {
        private static string EnderecoBase = "https://ws.spacedu.com/xf2018/rest/api";
        public static Usuario GetUsuario(Usuario usuario)
        {
            var url = EnderecoBase + "/usuario";

            /*
             * QueryString 
             * StringContent param = new StringContent(string.Format("?nome={0}&password{1}", usuario.nome, usuario.password));
            */
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] 
            {
                new KeyValuePair<string,string>("nome", usuario.nome),
                new KeyValuePair<string, string>("password",usuario.password)
            });


            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(url, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                //TODO - Deserializar, retornar metodo e salvar como login.
            }
            return null;
        }

        public static List<Chat> GetChats()
        {
            var URL = EnderecoBase + "/chats";

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (conteudo.Length > 2)
                {
                    List<Chat> lista = JsonConvert.DeserializeObject<List<Chat>>(conteudo);
                    return lista;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            
        }
    }
}
