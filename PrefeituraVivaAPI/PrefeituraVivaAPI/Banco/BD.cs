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
            CarregarUsuarios();
            CarregarVotacoes();
            CarregarInformacoes();
            CarregarReunioes();
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

            informacoes.Add(
                new Informacao
                {
                    IdInformacao = 1,
                    Titulo = "Rua esburacada",
                    Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Assunto = "Melhoria",
                    Tipo = "Reclamacao",

                });

            informacoes.Add(
                new Informacao
                {
                    IdInformacao = 2,
                    Titulo = "Iluminação Ruim",
                    Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Assunto = "Melhoria",
                    Tipo = "Reclamacao"

                });


            informacoes.Add(
                new Informacao
                {
                    IdInformacao = 3,
                    Titulo = "Novo quebra mola",
                    Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Assunto = "Melhoria",
                    Tipo = "Sugestão",

                });
        }

        private static void CarregarReunioes()
        {

            reunioes.Add(
                new Reuniao()
                {
                    Id_Reuniao = 1,
                    Endereco = "Rua verde, 500",
                    Tema = "Reunião para decidir sobre a revitalização das praças",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Horario = new DateTime(2017, 11, 02, 15, 30, 00)
                });

            reunioes.Add(
                new Reuniao()
                {
                    Id_Reuniao = 2,
                    Endereco = "Rua Afonso Pena, 323",
                    Tema = "Reunião para decidir sobre a criação de um novo zoologico",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Horario = new DateTime(2017, 11, 10, 15, 30, 00)
                });
            reunioes.Add(
                new Reuniao()
                {
                    Id_Reuniao = 3,
                    Endereco = "Rua dos Bandeirantes, 500",
                    Tema = "Assembleia para decidir sobre a recuperação de Igrejas",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut quam pretium enim placerat tincidunt in a nunc. Integer quis pretium felis. In quis enim ut orci dapibus vestibulum. Aliquam.",
                    Horario = new DateTime(2017, 11, 18, 15, 30, 00)
                });
        }

        private static void CarregarUsuarios()
        {

            usuarios.Add(
                new Usuario()
                {
                    IdUsuario = 1,
                    Nome = "Jose luiz",
                    Senha = "Panela23Verde",
                    Cpf = "113.323.233-00",
                    Idade = 46,
                    Sexo = "Masculino",
                    Email = "joseluiz@provedor.com",

                });

            usuarios.Add(
                new Usuario()
                {
                    IdUsuario = 2,
                    Nome = "Maria Joaquina",
                    Senha = "ValeriaValeriano2",
                    Cpf = "332.442.523-00",
                    Idade = 25,
                    Sexo = "Feminino",
                    Email = "maria.joaquina@provedor.com",

                });

            usuarios.Add(
                new Usuario()
                {
                    IdUsuario = 3,
                    Nome = "Joaozinho Silva",
                    Senha = "joao123456.",
                    Cpf = "523.524.332-42",
                    Idade = 78,
                    Sexo = "Masculino",
                    Email = "joaozinhosilva@provedor.com",

                });
        }
    }
}