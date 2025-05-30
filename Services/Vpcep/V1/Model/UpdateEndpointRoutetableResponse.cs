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
    /// Response Object
    /// </summary>
    public class UpdateEndpointRoutetableResponse : SdkResponse
    {

        /// <summary>
        /// 路由表ID列表。 若未指定，返回默认VPC下路由表ID。 更新Gateway类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Routetables { get; set; }

        /// <summary>
        /// 当修改终端节点子网路由表失败时，返回错误提示信息
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoutetableInfoError> Error { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointRoutetableResponse {\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointRoutetableResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointRoutetableResponse input)
        {
            if (input == null) return false;
            if (this.Routetables != input.Routetables || (this.Routetables != null && input.Routetables != null && !this.Routetables.SequenceEqual(input.Routetables))) return false;
            if (this.Error != input.Error || (this.Error != null && input.Error != null && !this.Error.SequenceEqual(input.Error))) return false;

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
                if (this.Routetables != null) hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }
}
