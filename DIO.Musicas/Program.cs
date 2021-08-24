using System;

namespace DIO.Musicas
{
    class Program
    {
        static MusicaRepositorio repositorio = new MusicaRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarMusica();
                        break;
                    case "2":
                        InserirMusica();
                        break;
                    case "3":
                        AtualizarMusica();
                        break;
                    case "4":
                        ExcluirMusica();
                        break;
                    case "5":
                        VisualizarMusica();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();

            }
            Console.WriteLine("Obrigado por Utilizar nossos Servicos");
            Console.ReadLine();
        }

        private static void VisualizarMusica()
        {
            Console.Clear();
            Console.WriteLine("===== Visualizar Musicas =====");
            Console.Write("Digita o id da Musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorID(indiceMusica);
            Console.WriteLine(serie);
        }
        private static void VisualizarMusica(int indiceMusica)
        { 
            var serie = repositorio.RetornaPorID(indiceMusica);

            Console.WriteLine(serie);
        }

        private static void ExcluirMusica()
        {
            Console.Clear();
            Console.WriteLine("====== Excluir Musica ======");
            Console.WriteLine("");
            Console.Write("Digite id da Musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());
            VisualizarMusica(indiceMusica);
            Console.WriteLine("====== Musica Excluida =======");
        }

        private static void AtualizarMusica()
        {
            Console.Clear();
            Console.WriteLine("====== Atualizar Musica ======");
            Console.WriteLine("");
            Console.Write("Digite id da Music: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Nome do Artista: ");
            string entradaArtista = Console.ReadLine();

            Console.WriteLine("Digite o Titulo da Musica: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite Nome do Album: ");
            string entradaAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Lancamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite um Genero entre os generos acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Musica atualizarMusica = new Musica(id: indiceMusica,
                                        artista: entradaArtista,
                                        titulo: entradaTitulo,
                                        album: entradaAlbum,
                                        dataLancamento: entradaAno,
                                        genero: (Genero)entradaGenero);

            repositorio.Atualiza(indiceMusica,atualizarMusica);
        }

        private static void InserirMusica()
        {
            Console.Clear();
            Console.WriteLine("====== Inserir Nova Musica ======");
            Console.WriteLine("");
            
            Console.WriteLine("Digite Nome do Artista: ");
            string entradaArtista = Console.ReadLine();

            Console.WriteLine("Digite o Titulo da Musica: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite Nome do Album: ");
            string entradaAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Lancamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite um Genero entre os generos acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Musica novaMusica = new Musica(id: repositorio.ProximoId(),
                                        artista: entradaArtista,
                                        titulo: entradaTitulo,
                                        album: entradaAlbum,
                                        dataLancamento: entradaAno,
                                        genero: (Genero)entradaGenero);

            repositorio.Inserir(novaMusica);
        }

        private static void ListarMusica()
        {
            Console.Clear();
            Console.WriteLine("======== Listar series ========");

            var lista = repositorio.Listas();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Musica Encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                var Excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaID(), serie.retornaTitulo(),(Excluido ? "Excluido" : ""));
               
                
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Plataforma de Musicas!!!");
            Console.WriteLine("=========== MENU ============");

            Console.WriteLine("1- Listar Musicas ");
            Console.WriteLine("2- Iserir nova Musica");
            Console.WriteLine("3- Atualizar Musica ");
            Console.WriteLine("4- Excluir Musica ");
            Console.WriteLine("5- Visualizar Musica ");
            Console.WriteLine("C- Limpar Tela ");
            Console.WriteLine("X- Sair ");

            Console.WriteLine("====Informe a Opcao =====");
            Console.Write("Opcao: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
