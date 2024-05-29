using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain.Relatorio;

public class CriarRelatorio
{
    private BaseFont fonteBase;

    public CriarRelatorio()
    {
        fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
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

        return new Document(PageSize.A4, lateralEsq, lateralDir, superior, inferior);
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

}
