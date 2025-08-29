using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace DSDIIPamonharia.Core
{
    public class Utilities
    {
        public static class ImageHelper
        {
            public static byte[] ImageToBytes(System.Drawing.Image img)
            {
                if (img == null)
                    return null;

                using (var ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    return ms.ToArray();
                }
            }

            public static System.Drawing.Image BytesToImage(byte[] bytes)
            {
                if (bytes == null || bytes.Length == 0)
                    return null;

                using (var ms = new MemoryStream(bytes))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }

        }

        public static class Validadores
        {
            public static bool VControles(Control container)
            {
                foreach (Control ctrl in container.Controls)
                {
                    if (ctrl is MaterialTextBox txt1 && string.IsNullOrWhiteSpace(txt1.Text))
                        return false;

                    if (ctrl is MaterialTextBox2 txt2 && string.IsNullOrWhiteSpace(txt2.Text))
                        return false;

                    if (ctrl is MaterialComboBox combo && string.IsNullOrWhiteSpace(combo.Text))
                        return false;

                    // Se tiver filhos, chama recursivamente
                    if (ctrl.HasChildren)
                    {
                        if (!VControles(ctrl))
                            return false;
                    }
                }
                return true;
            }
        }



        public class PdfGenerator
        {
            public static void GerarPdfGenerico<T>(List<T> lista, string tituloRelatorio)
            {
                try
                {
                    if (lista == null || lista.Count == 0)
                    {
                        MessageBox.Show("Lista vazia. Nenhum PDF gerado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Caminho na Área de Trabalho com timestamp
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string nomeArquivo = $"{tituloRelatorio}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    string caminhoArquivo = Path.Combine(desktop, nomeArquivo);

                    Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));
                    doc.Open();

                    Paragraph titulo = new Paragraph(tituloRelatorio);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    titulo.SpacingAfter = 20f;
                    doc.Add(titulo);

                    PropertyInfo[] props = typeof(T).GetProperties();
                    PdfPTable tabela = new PdfPTable(props.Length);
                    tabela.WidthPercentage = 100;

                    // Cabeçalho
                    foreach (var prop in props)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(prop.Name));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5;
                        tabela.AddCell(cell);
                    }

                    // Dados
                    foreach (var item in lista)
                    {
                        foreach (var prop in props)
                        {
                            object value = prop.GetValue(item) ?? "";
                            tabela.AddCell(value.ToString());
                        }
                    }

                    doc.Add(tabela);
                    doc.Close();
                    
                    if (File.Exists(caminhoArquivo))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = caminhoArquivo,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void GerarRelatorioVenda(List<VendasModel> vendas)
            {
                try
                {
                    if (vendas == null || vendas.Count == 0)
                    {
                        MessageBox.Show("Nenhuma venda encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Caminho na Área de Trabalho
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string nomeArquivo = $"Relatorio_Vendas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    string caminhoArquivo = Path.Combine(desktop, nomeArquivo);

                    Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));
                    doc.Open();

                    // Título
                    Paragraph titulo = new Paragraph("Relatório de Vendas Detalhado");
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    titulo.SpacingAfter = 20f;
                    doc.Add(titulo);

                    // Tabela detalhada
                    PdfPTable tabela = new PdfPTable(5);
                    tabela.WidthPercentage = 100;
                    tabela.SetWidths(new float[] { 10, 30, 15, 15, 15 });

                    string[] headers = { "ID", "Produto", "Quantidade", "Preço Unitário", "Total" };
                    foreach (var h in headers)
                    {
                        var cell = new PdfPCell(new Phrase(h));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5;
                        tabela.AddCell(cell);
                    }

                    foreach (var v in vendas)
                    {
                        tabela.AddCell(v.Id_item.ToString());
                        tabela.AddCell(v.Nome);
                        tabela.AddCell(v.Quantidade.ToString());
                        tabela.AddCell(v.Preco.ToString("C2"));
                        tabela.AddCell((v.Quantidade * v.Preco).ToString("C2"));
                    }

                    doc.Add(tabela);
                    doc.Add(new Paragraph("\n"));

                    // Gráfico de vendas por produto
                    Chart chart = new Chart();
                    chart.Width = 600;
                    chart.Height = 400;
                    chart.BackColor = Color.White;
                    chart.ChartAreas.Add(new ChartArea("Area"));

                    Series series = new Series("Vendas");
                    series.ChartType = SeriesChartType.Column;

                    var vendasPorProduto = vendas
                        .GroupBy(v => v.Nome)
                        .Select(g => new { Produto = g.Key, Total = g.Sum(x => x.Quantidade * x.Preco) })
                        .OrderByDescending(x => x.Total);

                    foreach (var item in vendasPorProduto)
                    {
                        series.Points.AddXY(item.Produto, item.Total);
                    }

                    chart.Series.Add(series);
                    chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    chart.ChartAreas[0].AxisX.Interval = 1;

                    string caminhoGrafico = Path.Combine(Path.GetTempPath(), $"grafico_{DateTime.Now.Ticks}.png");
                    chart.SaveImage(caminhoGrafico, ChartImageFormat.Png);

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(caminhoGrafico);
                    img.Alignment = Element.ALIGN_CENTER;
                    img.ScaleToFit(500f, 300f);
                    doc.Add(img);

                    doc.Close();
                    File.Delete(caminhoGrafico);

                    if (File.Exists(caminhoArquivo))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = caminhoArquivo,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar relatório de vendas:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

