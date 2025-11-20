using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DownloadSchemaMetadataResponse : SdkResponse
    {

        /// <summary>
        /// 逻辑库信息。
        /// </summary>
        [JsonProperty("compressed_databases_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressedDatabasesInfo { get; set; }

        /// <summary>
        /// 关联的后端DN信息。
        /// </summary>
        [JsonProperty("data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DnInstanceInfo> DataNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadSchemaMetadataResponse {\n");
            sb.Append("  compressedDatabasesInfo: ").Append(CompressedDatabasesInfo).Append("\n");
            sb.Append("  dataNodes: ").Append(DataNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadSchemaMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadSchemaMetadataResponse input)
        {
            if (input == null) return false;
            if (this.CompressedDatabasesInfo != input.CompressedDatabasesInfo || (this.CompressedDatabasesInfo != null && !this.CompressedDatabasesInfo.Equals(input.CompressedDatabasesInfo))) return false;
            if (this.DataNodes != input.DataNodes || (this.DataNodes != null && input.DataNodes != null && !this.DataNodes.SequenceEqual(input.DataNodes))) return false;

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
                if (this.CompressedDatabasesInfo != null) hashCode = hashCode * 59 + this.CompressedDatabasesInfo.GetHashCode();
                if (this.DataNodes != null) hashCode = hashCode * 59 + this.DataNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
