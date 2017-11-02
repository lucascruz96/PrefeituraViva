using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrefeituraVivaAPI.Models;

namespace PrefeituraVivaAPI.Banco
{
    public class BD
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Votacao> votacoes = new List<Votacao>();
        public static List<Informacao> informacoes = new List<Informacao>();
        public static List<Reuniao> reunioes = new List<Reuniao>();

        public static void Start()
        {
            //CarregarUsuarios();
            CarregarVotacoes();
            //CarregarInformacoes();
            //CarregarReunioes();
        }

        private static void CarregarVotacoes()
        {
            votacoes.Add(
                new Votacao()
                {
                    Id_vota = 1,
                    Assunto = "Revitalização da praça Raul Soares",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam."
                });

            votacoes.Add(
                new Votacao()
                {
                    Id_vota = 2,
                    Assunto = "Alteração do horario de funcionamento do metrô",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam."
                });

            votacoes.Add(
                new Votacao()
                {
                    Id_vota = 3,
                    Assunto = "Lei para regulamentar aplicativos de transporte",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam."
                });
        }

        private static void CarregarInformacoes()
        {
            throw new NotImplementedException();
        }

        private static void CarregarReunioes()
        {
            throw new NotImplementedException();
        }

        private static void CarregarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}