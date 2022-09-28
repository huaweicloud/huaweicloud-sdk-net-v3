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
        /// 路由表ID列表。节点的白名单。 此参数可以添加IPv4或CIDR： ● 当取值不为空时，表示将白名单更新为取值所示内容。 ● 当取值为空时，表示删除所有白名单。 默认为空列表。
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
            if (input == null)
                return false;

            return 
                (
                    this.Routetables == input.Routetables ||
                    this.Routetables != null &&
                    input.Routetables != null &&
                    this.Routetables.SequenceEqual(input.Routetables)
                ) && 
                (
                    this.Error == input.Error ||
                    this.Error != null &&
                    input.Error != null &&
                    this.Error.SequenceEqual(input.Error)
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }
}
