using System.IO;
using CrimsonTree.ExcelDataReader.Core;
using CrimsonTree.ExcelDataReader.Core.OpenXmlFormat;

namespace CrimsonTree.ExcelDataReader
{
    internal class ExcelOpenXmlReader : ExcelDataReader<XlsxWorkbook, XlsxWorksheet>
    {
        public ExcelOpenXmlReader(Stream stream)
        {
            Document = new ZipWorker(stream);
            Workbook = new XlsxWorkbook(Document);

            // By default, the data reader is positioned on the first result.
            Reset();
        }

        private ZipWorker Document { get; set; }

        public override void Close()
        {
            base.Close();

            Document?.Dispose();
            Workbook = null;
            Document = null;
        }
    }
}
