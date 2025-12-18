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
    public class UpdateClusterLongAKSKConfigRequestBody 
    {

        /// <summary>
        /// **参数解释：** 是否启用LongAKSK，启用后在集群kube-system命名空间下会创建名称为paas.longaksk的密钥，关闭则会删除该密钥。 **约束限制：** 不涉及 **取值范围：** - false: 禁用LongAKSK - true: 启用LongAKSK  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enableLongAKSK", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLongAKSK { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClusterLongAKSKConfigRequestBody {\n");
            sb.Append("  enableLongAKSK: ").Append(EnableLongAKSK).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClusterLongAKSKConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateClusterLongAKSKConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.EnableLongAKSK != input.EnableLongAKSK || (this.EnableLongAKSK != null && !this.EnableLongAKSK.Equals(input.EnableLongAKSK))) return false;

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
                if (this.EnableLongAKSK != null) hashCode = hashCode * 59 + this.EnableLongAKSK.GetHashCode();
                return hashCode;
            }
        }
    }
}
