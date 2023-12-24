using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Mixed_Vectors
{
    public partial class Form1 : Form
    {
        public double[] vectorA, vectorB, vectorC;
        public double result;

        // Form1() ���������� ��� ������� ���������
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // ButtonCalculate_Click() ���������� ��� ������� �� ������ "����������"
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBoxFirstVectorX.Text != string.Empty && textBoxFirstVectorY.Text != string.Empty && textBoxFirstVectorZ.Text != string.Empty
                    && textBoxSecondVectorX.Text != string.Empty && textBoxSecondVectorY.Text != string.Empty && textBoxSecondVectorZ.Text !=
                    string.Empty && textBoxThirdVectorX.Text != string.Empty && textBoxThirdVectorY.Text != string.Empty && textBoxThirdVectorZ.Text
                    != string.Empty)
            {
                MessageBox.Show("������� ��������!");
            }
            else
            {
                MessageBox.Show("������� �� ��������!");
            }
        }

        // ButtonInstruction_Click() ���������� ��� ������� �� ������ "����������"
        private void ButtonInstruction_Click(object sender, EventArgs e)
        {
            Instruction();
        }

        // ButtonWord_Click() ���������� ��� ������� �� ������ "������� � ����"
        private void ButtonWord_Click(object sender, EventArgs e)
        {
            ExportToWord();
        }

        // ButtonExcel_Click() ���������� ��� ������� �� ������ "������� � Excel"
        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        // ButtonPDF_Click() ���������� ��� ������� �� ������ "������� � PDF"
        private void ButtonPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        // ButtonClear_Click() ���������� ��� ������� �� ������ "��������"
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("��� ���� �������!");
        }

        // ButtonExit_Click() ���������� ��� �������� �� ������ "�����"
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Calculate() ���������� ��� ��������
        private void Calculate()
        {
            try
            {
                vectorA = vectorB = vectorC = null;
                result = 0;
                if (textBoxFirstVectorX.Text != string.Empty && textBoxFirstVectorY.Text != string.Empty && textBoxFirstVectorZ.Text != string.Empty
                    && textBoxSecondVectorX.Text != string.Empty && textBoxSecondVectorY.Text != string.Empty && textBoxSecondVectorZ.Text !=
                    string.Empty && textBoxThirdVectorX.Text != string.Empty && textBoxThirdVectorY.Text != string.Empty && textBoxThirdVectorZ.Text
                    != string.Empty)
                {
                    vectorA = [double.Parse(textBoxFirstVectorX.Text), double.Parse(textBoxFirstVectorY.Text), double.Parse(textBoxFirstVectorZ.Text)];
                    vectorB = [double.Parse(textBoxSecondVectorX.Text),
                        double.Parse(textBoxSecondVectorY.Text),
                        double.Parse(textBoxSecondVectorZ.Text)];
                    vectorC = [double.Parse(textBoxThirdVectorX.Text), double.Parse(textBoxThirdVectorY.Text), double.Parse(textBoxThirdVectorZ.Text)];
                    result = vectorA[0] * (vectorB[1] * vectorC[2] - vectorB[2] * vectorC[1]) + vectorA[1] * (vectorB[2] * vectorC[0] - vectorB[0] *
                        vectorC[2]) + vectorA[2] * (vectorB[0] * vectorC[1] - vectorB[1] * vectorC[0]);
                    labelResult.Text = $"�����: {result:F2}";
                }
                else
                {
                    Clear();
                    MessageBox.Show("������� �����!");
                }
            }
            catch
            {
                Clear();
                MessageBox.Show("����� ������� ������ �����!");
            }
        }

        // Instruction() ���������� ��� �������� ����������
        private void Instruction()
        {
            try
            {
                MessageBox.Show("��� ���� ����� ����� ��������� ������������ ��������:\r\n������� �������� ��������;\r\n������� ������ " +
                "\"����������\" � �� �������� ��������� ������� ������;\r\n������� ������ \"������� � Word\" � �� �������� ������ �" +
                " �������� � ��������� \"Word\";\r\n������� ������ \"������� � Excel\" � �� �������� ������ � �������� � ��������� " +
                "\"Excel\";\r\n������� ������ \"������� � PDF\" � �� �������� ������ � �������� � ������� .pdf;\r\n������� ������ " +
                "\"��������\" � ��� ���� ����� �������;\r\n������� ������ \"�����\" � ��������� ���������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ExportToWord() ���������� ��� �������� � Word
        private void ExportToWord()
        {
            try
            {
                Calculate();
                Word.Application wordApp = new();
                wordApp.Visible = true;
                Word.Document doc = wordApp.Documents.Add();
                doc.Content.Text = $"��������� ���������� ������������ ��������\n" +
                    $"������ ������:\n{textBoxFirstVectorName.Text} = " + "{" + $"{textBoxFirstVectorX.Text} ; {textBoxFirstVectorY.Text} ; " +
                    $"{textBoxFirstVectorZ.Text}" + "}" + $"\n������ ������:\n{textBoxSecondVectorName.Text} = " + "{" +
                    $"{textBoxSecondVectorX.Text} ; {textBoxSecondVectorY.Text} ; {textBoxSecondVectorZ.Text}" + "}" + $"\n������ ������:\n" +
                    $"{textBoxThirdVectorName.Text} = " + "{" + $"{textBoxThirdVectorX.Text} ; {textBoxThirdVectorY.Text} ; " +
                    $"{textBoxThirdVectorZ.Text}" + "}" + $"\n�������: {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}z + {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}x + {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}y - {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}x - {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}z - {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}y = {textBoxFirstVectorX.Text} * {textBoxSecondVectorY.Text} * {textBoxThirdVectorZ.Text} + " +
                    $"{textBoxFirstVectorY.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorX.Text} + {textBoxFirstVectorZ.Text} * " +
                    $"{textBoxSecondVectorX.Text} * {textBoxThirdVectorY.Text} - {textBoxFirstVectorZ.Text} * {textBoxSecondVectorY.Text} * " +
                    $"{textBoxThirdVectorX.Text} - {textBoxFirstVectorY.Text} * {textBoxSecondVectorX.Text} * {textBoxThirdVectorZ.Text} - " +
                    $"{textBoxFirstVectorX.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorY.Text} = {result:F2}";
                MessageBox.Show("������� � Word ��������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ExportToExcel() ���������� ��� �������� � Excel
        private void ExportToExcel()
        {
            try
            {
                Calculate();
                Excel.Application excelApp = new();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Worksheets[1];
                worksheet.Cells[1, 1] = $"��������� ���������� ������������ ��������\n" +
                    $"������ ������:\n{textBoxFirstVectorName.Text} = " + "{" + $"{textBoxFirstVectorX.Text} ; {textBoxFirstVectorY.Text} ; " +
                    $"{textBoxFirstVectorZ.Text}" + "}" + $"\n������ ������:\n{textBoxSecondVectorName.Text} = " + "{" +
                    $"{textBoxSecondVectorX.Text} ; {textBoxSecondVectorY.Text} ; {textBoxSecondVectorZ.Text}" + "}" + $"\n������ ������:\n" +
                    $"{textBoxThirdVectorName.Text} = " + "{" + $"{textBoxThirdVectorX.Text} ; {textBoxThirdVectorY.Text} ; " +
                    $"{textBoxThirdVectorZ.Text}" + "}" + $"\n�������: {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}z + {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}x + {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}y - {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}x - {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}z - {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}y = {textBoxFirstVectorX.Text} * {textBoxSecondVectorY.Text} * {textBoxThirdVectorZ.Text} + " +
                    $"{textBoxFirstVectorY.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorX.Text} + {textBoxFirstVectorZ.Text} * " +
                    $"{textBoxSecondVectorX.Text} * {textBoxThirdVectorY.Text} - {textBoxFirstVectorZ.Text} * {textBoxSecondVectorY.Text} * " +
                    $"{textBoxThirdVectorX.Text} - {textBoxFirstVectorY.Text} * {textBoxSecondVectorX.Text} * {textBoxThirdVectorZ.Text} - " +
                    $"{textBoxFirstVectorX.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorY.Text} = {result:F2}";
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
                Excel.Range rangeToMerge = worksheet.Range["A1:E1"];
                rangeToMerge.Merge();
                MessageBox.Show("������� � Excel ��������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ExportToPDF() ���������� ��� �������� � PDF
        private void ExportToPDF()
        {
            try
            {
                Calculate();
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.pdf");
                using var pdfWriter = new PdfWriter(filePath);
                using var pdfDocument = new PdfDocument(pdfWriter);
                using var pdfDoc = new Document(pdfDocument);
                PdfFont timesFont = PdfFontFactory.CreateFont("c:/windows/fonts/times.ttf", PdfEncodings.IDENTITY_H, true);
                pdfDoc.Add(new Paragraph($"��������� ���������� ������������ ��������\n" +
                    $"������ ������:\n{textBoxFirstVectorName.Text} = " + "{" + $"{textBoxFirstVectorX.Text} ; {textBoxFirstVectorY.Text} ; " +
                    $"{textBoxFirstVectorZ.Text}" + "}" + $"\n������ ������:\n{textBoxSecondVectorName.Text} = " + "{" +
                    $"{textBoxSecondVectorX.Text} ; {textBoxSecondVectorY.Text} ; {textBoxSecondVectorZ.Text}" + "}" + $"\n������ ������:\n" +
                    $"{textBoxThirdVectorName.Text} = " + "{" + $"{textBoxThirdVectorX.Text} ; {textBoxThirdVectorY.Text} ; " +
                    $"{textBoxThirdVectorZ.Text}" + "}" + $"\n�������: {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}z + {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}x + {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}y - {textBoxFirstVectorName.Text}z * {textBoxSecondVectorName.Text}y * " +
                    $"{textBoxThirdVectorName.Text}x - {textBoxFirstVectorName.Text}y * {textBoxSecondVectorName.Text}x * " +
                    $"{textBoxThirdVectorName.Text}z - {textBoxFirstVectorName.Text}x * {textBoxSecondVectorName.Text}z * " +
                    $"{textBoxThirdVectorName.Text}y = {textBoxFirstVectorX.Text} * {textBoxSecondVectorY.Text} * {textBoxThirdVectorZ.Text} + " +
                    $"{textBoxFirstVectorY.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorX.Text} + {textBoxFirstVectorZ.Text} * " +
                    $"{textBoxSecondVectorX.Text} * {textBoxThirdVectorY.Text} - {textBoxFirstVectorZ.Text} * {textBoxSecondVectorY.Text} * " +
                    $"{textBoxThirdVectorX.Text} - {textBoxFirstVectorY.Text} * {textBoxSecondVectorX.Text} * {textBoxThirdVectorZ.Text} - " +
                    $"{textBoxFirstVectorX.Text} * {textBoxSecondVectorZ.Text} * {textBoxThirdVectorY.Text} = {result:F2}").SetFont(timesFont));
                pdfDocument.Close();
                MessageBox.Show("������� � PDF ��������!");
                ProcessStartInfo psi = new()
                {
                    FileName = "cmd",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process process = new() { StartInfo = psi };
                process.Start();
                process.StandardInput.WriteLine($"start {filePath}");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clear() ���������� ��� ������� ���� �����
        private void Clear()
        {
            try
            {
                textBoxFirstVectorX.Text = string.Empty;
                textBoxFirstVectorY.Text = string.Empty;
                textBoxFirstVectorZ.Text = string.Empty;
                textBoxSecondVectorX.Text = string.Empty;
                textBoxSecondVectorY.Text = string.Empty;
                textBoxSecondVectorZ.Text = string.Empty;
                textBoxThirdVectorX.Text = string.Empty;
                textBoxThirdVectorY.Text = string.Empty;
                textBoxThirdVectorZ.Text = string.Empty;
                labelResult.Text = $"�����: ";
                vectorA = vectorB = vectorC = null;
                result = 0;
                textBoxFirstVectorName.Text = "a";
                textBoxSecondVectorName.Text = "b";
                textBoxThirdVectorName.Text = "c";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}