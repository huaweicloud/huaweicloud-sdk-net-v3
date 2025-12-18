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
    /// Response Object
    /// </summary>
    public class GetClusterLongAkskConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 集群是否上传了LongAKSK。 **约束限制：** 不涉及 **取值范围：** - false: 未上传LongAKSK - true: 已上传LongAKSK  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("hasUploadedLongAKSK", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasUploadedLongAKSK { get; set; }

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
            sb.Append("class GetClusterLongAkskConfigResponse {\n");
            sb.Append("  hasUploadedLongAKSK: ").Append(HasUploadedLongAKSK).Append("\n");
            sb.Append("  enableLongAKSK: ").Append(EnableLongAKSK).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetClusterLongAkskConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetClusterLongAkskConfigResponse input)
        {
            if (input == null) return false;
            if (this.HasUploadedLongAKSK != input.HasUploadedLongAKSK || (this.HasUploadedLongAKSK != null && !this.HasUploadedLongAKSK.Equals(input.HasUploadedLongAKSK))) return false;
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
                if (this.HasUploadedLongAKSK != null) hashCode = hashCode * 59 + this.HasUploadedLongAKSK.GetHashCode();
                if (this.EnableLongAKSK != null) hashCode = hashCode * 59 + this.EnableLongAKSK.GetHashCode();
                return hashCode;
            }
        }
    }
}
