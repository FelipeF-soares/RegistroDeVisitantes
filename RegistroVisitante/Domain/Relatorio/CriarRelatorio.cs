using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain.Relatorio;

public class CriarRelatorio
{
    private BaseFont fonteBase;
    private iTextSharp.text.Font fonteCelula;
    private string caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"img\\logo.png");

    public CriarRelatorio()
    {
        fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        fonteCelula = new iTextSharp.text.Font(fonteBase, 10, iTextSharp.text.Font.NORMAL, BaseColor.Black);
    }
    public void GerarRelatorioEmPDF(Visitante[] visitantes) 
    {
        
        if(visitantes.Length > 0)
        {
            var pdf = ConfiguracaoDaPagina(15F, 15F, 15F, 20F, true);
            var nomeDoArquivo = GerarNomeDoArquivo("Visitantes");
            var arquivo = CriaArquivo(nomeDoArquivo);
            var writer = GerarDocumentoPDF(pdf, arquivo);
            pdf.Open();
            var titulo = CriarTitulo("Relatório de Visitantes",32);
            pdf.Add(titulo);
            AdicionaLogo(caminhoLogo, pdf, writer);
            var tabela = CriaTabela(7);
            string[] listaDeValores = { "Nome Completo","RG","Informações", "Bloco", "Apto", "Horário Entrada", "Horário Saída"};
            VinculaCelulaATabela(tabela, listaDeValores);
            VinculaValorACelula(tabela, visitantes);
            pdf.Add(tabela);
            pdf.Close();
            arquivo.Close();
            AbrePDF(nomeDoArquivo);
        }
    }

    public void GeraRelatorioDePassagemDeServico(LivroDePassagemDeServico passagem)
    {
        var pdf = ConfiguracaoDaPagina(15F, 15F, 15F, 20F, false);
        var nomeDoArquivo = GerarNomeDoArquivo("PassagemDeServiço");
        var arquivo = CriaArquivo(nomeDoArquivo);
        var writer = GerarDocumentoPDF(pdf, arquivo);
        pdf.Open();
        var titulo = CriarTitulo($"Relatório De Passagem De Serviço\nCond. Altos Pq. Do Carmo.",20);
        pdf.Add(titulo);
        AdicionaLogo(caminhoLogo, pdf, writer);
        var nomecolaborador = CriarParagrafo($"COLABORADOR: {passagem.NomeColaborador} EM {DateTime.Now.ToString("dd/MM/yy")}\n");
        pdf.Add(nomecolaborador);
        var conteudo = CriarParagrafo(passagem.RelatorioDiario);
        pdf.Add(conteudo);
        pdf.Close();
        arquivo.Close();
        AbrePDF(nomeDoArquivo);
    }

    private Document ConfiguracaoDaPagina(float lateralEsq, float lateralDir, float superior, float inferior, bool horizontal)
    {
        var pxPorMm = 72 / 25.2F;
        superior = superior * pxPorMm;
        inferior = inferior * pxPorMm;
        lateralEsq = lateralEsq * pxPorMm;
        lateralDir = lateralDir * pxPorMm;
        if(horizontal == true)
        {
            return new Document(PageSize.A4.Rotate(), lateralEsq, lateralDir, superior, inferior);
        }
        else
        {
            return new Document(PageSize.A4, lateralEsq, lateralDir, superior, inferior);
        }

        
    }

    private string GerarNomeDoArquivo(string tipoRelatorio)
    {
        return $"{tipoRelatorio}.{DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss")}.pdf";
    }

    private PdfWriter GerarDocumentoPDF( Document pdf, FileStream arquivo)
    {
        return PdfWriter.GetInstance(pdf, arquivo);
    }

    private FileStream CriaArquivo(string nomeDoArquivo)
    {
        return new FileStream($"relatorio\\{nomeDoArquivo}", FileMode.Create);
    }

    private Paragraph CriarTitulo(string titulo,int tamanhoFont)
    {
        var fonteTitulo =  new iTextSharp.text.Font(fonteBase, tamanhoFont, iTextSharp.text.Font.NORMAL, BaseColor.Black);
        var paragrafo = new Paragraph($"{titulo}\n\n", fonteTitulo);
        paragrafo.Alignment = Element.ALIGN_LEFT;
        paragrafo.SpacingAfter = 4;
        return paragrafo;
    }
    private Paragraph CriarParagrafo(string conteudo)
    {
        var fonte = new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, BaseColor.Black);
        var paragrafo = new Paragraph($"{conteudo}", fonte);
        paragrafo.Alignment = Element.ALIGN_LEFT;
        paragrafo.SpacingAfter = 4;
        return paragrafo;
    }

    private void AbrePDF(string nomeDoArquivo)
    {
        var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,$"relatorio\\{nomeDoArquivo}");
        if(File.Exists(caminhoPDF))
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = $"/c start {caminhoPDF}",
                FileName = "cmd.exe",
                CreateNoWindow = true
            });
        }
    }

    private PdfPTable CriaTabela(int quantidadeColunas)
    {
        var tabela = new PdfPTable(quantidadeColunas);
        float[] largurasColunas = { 2.5f,1.5f,2.5f, 1f,1f, 1.5f, 1.5f};
        tabela.SetWidths(largurasColunas);
        tabela.DefaultCell.BorderWidth = 0;
        tabela.WidthPercentage = 100;
         return tabela;
    }

    private PdfPCell CriaCelula(string nome, PdfPTable tabela)
    {
        var bgColor = iTextSharp.text.BaseColor.White;
        if(tabela.Rows.Count % 2 ==1)
            {
            bgColor = new BaseColor(0.95F, 0.95F, 0.95F);
             }
        var celula = new PdfPCell(new Phrase(nome, fonteCelula));
        celula.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
        celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
        celula.Border = 0;
        celula.BorderWidthBottom = 1;
        celula.FixedHeight = 25;
        celula.PaddingBottom = 5;
        celula.BackgroundColor = bgColor;
        return celula;
    }

    private void VinculaCelulaATabela(PdfPTable tabela, string[] listaDeValores)
    {
        foreach(var valor in listaDeValores)
        {
            var celula = CriaCelula(valor, tabela);
            tabela.AddCell(celula);
        }
    }
    private void VinculaValorACelula(PdfPTable tabela, Visitante[] listaDeValores)
    {
       for(int i = 0;i < listaDeValores.Length; i++)
        {
            var nome = CriaCelula(listaDeValores[i].Nome,tabela);
            tabela.AddCell(nome);
            var rg = CriaCelula(listaDeValores[i].Rg, tabela);
            tabela.AddCell(rg);
            var informacoes = CriaCelula(listaDeValores[i].Informacoes, tabela);
            tabela.AddCell(informacoes);
            var bloco = CriaCelula(listaDeValores[i].Bloco, tabela);
            tabela.AddCell(bloco);
            var apto = CriaCelula(listaDeValores[i].Apto, tabela);
            tabela.AddCell(apto);
            var entrada = CriaCelula(listaDeValores[i].DataHoraEntrada.ToString("dd/MM/yy - HH:mm"), tabela);
            tabela.AddCell(entrada);
            var saida = CriaCelula(listaDeValores[i].DataHoraSaida.ToString(), tabela);
            tabela.AddCell(saida);
        }
    }

    private void AdicionaLogo(string caminhoLogo,Document pdf, PdfWriter writer)
    {
        if(File.Exists(caminhoLogo))
        {
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);
            float razaoAlturaLargura = logo.Width / logo.Height;
            float alturaLogo = 90;
            float larguraLogo = alturaLogo * razaoAlturaLargura;
            logo.ScaleToFit(larguraLogo, alturaLogo);
            var margemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
            var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 54;
            logo.SetAbsolutePosition(margemEsquerda, margemTopo);
            writer.DirectContent.AddImage(logo, false);
        }
    }
}
