using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 对象导入信息。
    /// </summary>
    public class SupportImportFileResult 
    {

        /// <summary>
        /// 文件导入阈值。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSize { get; set; }

        /// <summary>
        /// 上一次选择对象的方式。
        /// </summary>
        [JsonProperty("previous_select", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousSelect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportImportFileResult {\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  previousSelect: ").Append(PreviousSelect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportImportFileResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportImportFileResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.PreviousSelect == input.PreviousSelect ||
                    (this.PreviousSelect != null &&
                    this.PreviousSelect.Equals(input.PreviousSelect))
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
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.PreviousSelect != null)
                    hashCode = hashCode * 59 + this.PreviousSelect.GetHashCode();
                return hashCode;
            }
        }
    }
}
