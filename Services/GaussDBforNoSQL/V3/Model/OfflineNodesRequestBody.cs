using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 隔离节点请求体。
    /// </summary>
    public class OfflineNodesRequestBody 
    {

        /// <summary>
        /// 操作类型 ,shutdown代表关机,开机是startup。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 节点ID列表,最多10个。
        /// </summary>
        [JsonProperty("node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfflineNodesRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  nodeIds: ").Append(NodeIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OfflineNodesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OfflineNodesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.NodeIds == input.NodeIds ||
                    this.NodeIds != null &&
                    input.NodeIds != null &&
                    this.NodeIds.SequenceEqual(input.NodeIds)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
