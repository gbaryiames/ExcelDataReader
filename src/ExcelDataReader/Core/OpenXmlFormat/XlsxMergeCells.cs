using System.Collections.Generic;

namespace CrimsonTree.ExcelDataReader.Core.OpenXmlFormat
{
    internal class XlsxMergeCells : XlsxElement
    {
        public XlsxMergeCells()
            : base(XlsxElementType.MergeCells)
        {
        }

        public List<CellRange> Value { get; set; }
    }
}
