using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SecurityTarget 
    {

        /// <summary>
        /// 安全态势感知配置绑定的对象，目前仅支持PRODUCT产品级别，仅对设备级别的安全态势感知项生效。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 绑定对象id列表，target_type为PRODUCT时，由于产品ID在不同资源空间下可以重复，target_id格式为：资源空间ID:产品ID；资源空间ID与产品ID使用冒号拼接而成。
        /// </summary>
        [JsonProperty("target_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityTarget {\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetIds: ").Append(TargetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityTarget);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecurityTarget input)
        {
            if (input == null) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.TargetIds != input.TargetIds || (this.TargetIds != null && input.TargetIds != null && !this.TargetIds.SequenceEqual(input.TargetIds))) return false;

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
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetIds != null) hashCode = hashCode * 59 + this.TargetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
