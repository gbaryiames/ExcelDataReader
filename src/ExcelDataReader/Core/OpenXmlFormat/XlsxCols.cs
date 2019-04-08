using System.Collections.Generic;

namespace CrimsonTree.ExcelDataReader.Core.OpenXmlFormat
{
    internal class XlsxCols : XlsxElement
    {
        public XlsxCols()
            : base(XlsxElementType.Cols)
        {
        }

        public List<Col> Value { get; set; }
    }
}
