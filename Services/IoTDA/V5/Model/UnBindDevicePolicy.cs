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
    /// 解绑策略请求体。
    /// </summary>
    public class UnBindDevicePolicy 
    {

        /// <summary>
        /// **参数说明**：解除策略绑定的目标类型。 **取值范围**：device|product|app，device表示设备，product表示产品，app表示整个资源空间。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 策略解绑的目标ID列表 
        /// </summary>
        [JsonProperty("target_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnBindDevicePolicy {\n");
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
            return this.Equals(input as UnBindDevicePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnBindDevicePolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TargetIds == input.TargetIds ||
                    this.TargetIds != null &&
                    input.TargetIds != null &&
                    this.TargetIds.SequenceEqual(input.TargetIds)
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
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetIds != null)
                    hashCode = hashCode * 59 + this.TargetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
