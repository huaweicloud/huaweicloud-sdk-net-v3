using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ContainerNetworkUpdate 
    {

        /// <summary>
        /// 容器网络网段列表。1.21及新版本集群，当集群网络类型为vpc-router时，支持增量添加容器网段，最多配置20个。  此参数在集群更新后不可更改，请谨慎选择。
        /// </summary>
        [JsonProperty("cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContainerCIDR> Cidrs { get; set; }

        /// <summary>
        /// **参数解释：** 容器网络网段列表。当集群网络类型为vpc-router时，支持添加或删除容器网段。支持的集群版本如下： - v1.28.15-r60及以上版本 - v1.29.15-r20及以上版本 - v1.30.14-r20及以上版本 - v1.31.10-r20及以上版本 - v1.32.6-r20及以上版本 - v1.33.5-r10及以上版本  支持修改集群容器网段的顺序，顺序在前的容器网段优先被使用。 **约束限制：** - 最多支持配置20个子网。 - 填写为空时，该字段不生效。  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("containercidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Containercidrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerNetworkUpdate {\n");
            sb.Append("  cidrs: ").Append(Cidrs).Append("\n");
            sb.Append("  containercidrs: ").Append(Containercidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContainerNetworkUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContainerNetworkUpdate input)
        {
            if (input == null) return false;
            if (this.Cidrs != input.Cidrs || (this.Cidrs != null && input.Cidrs != null && !this.Cidrs.SequenceEqual(input.Cidrs))) return false;
            if (this.Containercidrs != input.Containercidrs || (this.Containercidrs != null && input.Containercidrs != null && !this.Containercidrs.SequenceEqual(input.Containercidrs))) return false;

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
                if (this.Cidrs != null) hashCode = hashCode * 59 + this.Cidrs.GetHashCode();
                if (this.Containercidrs != null) hashCode = hashCode * 59 + this.Containercidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
