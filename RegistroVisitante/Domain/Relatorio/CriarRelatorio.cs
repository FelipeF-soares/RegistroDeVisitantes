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

    public CriarRelatorio()
    {
        fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        fonteCelula = new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, BaseColor.Black);
    }
    public void GerarRelatorioEmPDF(Visitante[] visitantes) 
    {
        
        if(visitantes.Length > 0)
        {
            var pdf = ConfiguracaoDaPagina(15F, 15F, 15F, 20F);
            var nomeDoArquivo = GerarNomeDoArquivo();
            var arquivo = CriaArquivo(nomeDoArquivo);
            var writer = GerarDocumentoPDF(pdf, arquivo);
            pdf.Open();
            var titulo = CriarTitulo("Relatório de Visitantes");
            pdf.Add(titulo);
            var tabela = CriaTabela(5);
            string[] listaDeValores = { "Nome Completo", "Bloco", "Apto", "Horário Entrada", "Horário Saída"};
            VinculaCelulaATabela(tabela, listaDeValores);
            VinculaValorACelula(tabela, visitantes);
            pdf.Add(tabela);
            pdf.Close();
            arquivo.Close();
            AbrePDF(nomeDoArquivo);
        }
    }

    private Document ConfiguracaoDaPagina(float lateralEsq, float lateralDir, float superior, float inferior)
    {
        var pxPorMm = 72 / 25.2F;
        superior = superior * pxPorMm;
        inferior = inferior * pxPorMm;
        lateralEsq = lateralEsq * pxPorMm;
        lateralDir = lateralDir * pxPorMm;

        return new Document(PageSize.A4.Rotate(), lateralEsq, lateralDir, superior, inferior);
    }

    private string GerarNomeDoArquivo()
    {
        return $"Relatorio.{DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss")}.pdf";
    }

    private PdfWriter GerarDocumentoPDF( Document pdf, FileStream arquivo)
    {
        return PdfWriter.GetInstance(pdf, arquivo);
    }

    private FileStream CriaArquivo(string nomeDoArquivo)
    {
        return new FileStream(nomeDoArquivo, FileMode.Create);
    }

    private Paragraph CriarTitulo(string titulo)
    {
        var fonteTitulo =  new iTextSharp.text.Font(fonteBase,32,iTextSharp.text.Font.NORMAL, BaseColor.Black);
        var paragrafo = new Paragraph($"{titulo}\n\n", fonteTitulo);
        paragrafo.Alignment = Element.ALIGN_LEFT;
        return paragrafo;
    }

    private void AbrePDF(string nomeDoArquivo)
    {
        var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,nomeDoArquivo);
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
        float[] largurasColunas = { 2f, 1f,1f, 1.5f, 1.5f};
        tabela.SetWidths(largurasColunas);
        tabela.DefaultCell.BorderWidth = 0;
        tabela.WidthPercentage = 100;
         return tabela;
    }

    private PdfPCell CriaCelula(string nome)
    {
        var celula = new PdfPCell(new Phrase(nome, fonteCelula));
        celula.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
        celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
        celula.Border = 0;
        celula.BorderWidthBottom = 1;
        celula.FixedHeight = 25;
        return celula;
    }

    private void VinculaCelulaATabela(PdfPTable tabela, string[] listaDeValores)
    {
        foreach(var valor in listaDeValores)
        {
            var celula = CriaCelula(valor);
            tabela.AddCell(celula);
        }
    }
    private void VinculaValorACelula(PdfPTable tabela, Visitante[] listaDeValores)
    {
       for(int i = 0;i < listaDeValores.Length; i++)
        {
            var nome = CriaCelula(listaDeValores[i].Nome);
            tabela.AddCell(nome);
            var bloco = CriaCelula(listaDeValores[i].Bloco);
            tabela.AddCell(bloco);
            var apto = CriaCelula(listaDeValores[i].Apto);
            tabela.AddCell(apto);
            var entrada = CriaCelula(listaDeValores[i].DataHoraEntrada.ToString("dd/MM/yy - HH:mm"));
            tabela.AddCell(entrada);
            var saida = CriaCelula(listaDeValores[i].DataHoraSaida.ToString());
            tabela.AddCell(saida);
        }
    }
}
