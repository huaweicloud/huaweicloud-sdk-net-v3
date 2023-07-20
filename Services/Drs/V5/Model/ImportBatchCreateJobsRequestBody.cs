using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportBatchCreateJobsRequestBody : IFormDataBody
    {

        /// <summary>
        /// 待上传的模板文件。
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart File { get; set; }


        
        public ImportBatchCreateJobsRequestBody WithFile(Stream stream, string filename)
        {
            this.File = new FormDataFilePart(stream, filename);
            return this;
        }

        public ImportBatchCreateJobsRequestBody WithFile(Stream stream, string filename, string contentType)
        {
            this.File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("file", File);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportBatchCreateJobsRequestBody {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportBatchCreateJobsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportBatchCreateJobsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                return hashCode;
            }
        }
    }
}
