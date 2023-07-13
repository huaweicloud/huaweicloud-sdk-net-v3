using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBatchTaskFilesResponse : SdkResponse
    {

        /// <summary>
        /// 批量任务文件列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchTaskFile> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBatchTaskFilesResponse {\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBatchTaskFilesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBatchTaskFilesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
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
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
