using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportFactorRequestBody : IFormDataBody
    {

        /// <summary>
        /// 待导入文件
        /// </summary>
        [JsonProperty("excel_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart ExcelFile { get; set; }


        
        public ImportFactorRequestBody WithExcelFile(Stream stream, string filename)
        {
            this.ExcelFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public ImportFactorRequestBody WithExcelFile(Stream stream, string filename, string contentType)
        {
            this.ExcelFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("excel_file", ExcelFile);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportFactorRequestBody {\n");
            sb.Append("  excelFile: ").Append(ExcelFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportFactorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportFactorRequestBody input)
        {
            if (input == null) return false;
            if (this.ExcelFile != input.ExcelFile || (this.ExcelFile != null && !this.ExcelFile.Equals(input.ExcelFile))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ExcelFile != null) hashCode = hashCode * 59 + this.ExcelFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
