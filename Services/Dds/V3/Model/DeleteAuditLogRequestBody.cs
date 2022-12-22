using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteAuditLogRequestBody 
    {

        /// <summary>
        /// 文件名列表
        /// </summary>
        [JsonProperty("file_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FileNames { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAuditLogRequestBody {\n");
            sb.Append("  fileNames: ").Append(FileNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAuditLogRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAuditLogRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    input.FileNames != null &&
                    this.FileNames.SequenceEqual(input.FileNames)
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
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
