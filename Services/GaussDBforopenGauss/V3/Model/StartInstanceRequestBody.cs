using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StartInstanceRequestBody 
    {

        /// <summary>
        /// 需要启动的节点的ID，取值不能为null，如果为空列表则启动整个实例
        /// </summary>
        [JsonProperty("node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartInstanceRequestBody {\n");
            sb.Append("  nodeIds: ").Append(NodeIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartInstanceRequestBody input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
