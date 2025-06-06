using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScanClientsRequestBody 
    {

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 是否重新查询并保存会话列表
        /// </summary>
        [JsonProperty("clean_cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CleanCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanClientsRequestBody {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  cleanCache: ").Append(CleanCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScanClientsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScanClientsRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.CleanCache != input.CleanCache || (this.CleanCache != null && !this.CleanCache.Equals(input.CleanCache))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.CleanCache != null) hashCode = hashCode * 59 + this.CleanCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
