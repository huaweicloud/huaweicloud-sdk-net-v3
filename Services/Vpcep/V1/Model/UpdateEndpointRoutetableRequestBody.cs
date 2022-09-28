using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 更新终端节点路由表请求结构体
    /// </summary>
    public class UpdateEndpointRoutetableRequestBody 
    {

        /// <summary>
        /// 路由表ID列表。
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Routetables { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointRoutetableRequestBody {\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointRoutetableRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointRoutetableRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Routetables == input.Routetables ||
                    this.Routetables != null &&
                    input.Routetables != null &&
                    this.Routetables.SequenceEqual(input.Routetables)
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
                if (this.Routetables != null)
                    hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                return hashCode;
            }
        }
    }
}
