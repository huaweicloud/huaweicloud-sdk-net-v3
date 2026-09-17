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
    /// **参数解释：** 原地升级配置。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class InPlaceRollingUpdate 
    {

        /// <summary>
        /// **参数解释：** 每批升级的最大节点数量。升级时节点池之间会依次进行升级。节点池内的节点分批升级，第一批升级1个节点，第二批升级2个节点，后续每批升级节点数以2的幂数增加，直到达到您设置的每批最大升级节点数，并会持续作用在下一个节点池中 **约束限制：** 不涉及 **取值范围：** [1-120] **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("userDefinedStep", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserDefinedStep { get; set; }

        /// <summary>
        /// **参数解释：** 节点升级批次作用域 **约束限制：** 不涉及 **取值范围：** - Cluster：节点升级批次配置应用到整个集群，整个升级过程不重置升级批次 - NodePool：节点升级批次配置应用到节点池，升级每个节点池都会重置升级批次  **默认取值：** Cluster
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InPlaceRollingUpdate {\n");
            sb.Append("  userDefinedStep: ").Append(UserDefinedStep).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InPlaceRollingUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InPlaceRollingUpdate input)
        {
            if (input == null) return false;
            if (this.UserDefinedStep != input.UserDefinedStep || (this.UserDefinedStep != null && !this.UserDefinedStep.Equals(input.UserDefinedStep))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;

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
                if (this.UserDefinedStep != null) hashCode = hashCode * 59 + this.UserDefinedStep.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
