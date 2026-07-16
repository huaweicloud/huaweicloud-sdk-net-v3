using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：LVM配置管理。
    /// </summary>
    public class PoolSpecModelVolumeGroupConfigsLvmConfig 
    {

        /// <summary>
        /// **参数解释**：LVM写入模式 **取值范围**：可选项如下： - linear：线性模式。 - striped：条带模式，使用多块磁盘组成条带模式，能够提升磁盘性能。
        /// </summary>
        [JsonProperty("lvType", NullValueHandling = NullValueHandling.Ignore)]
        public string LvType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecModelVolumeGroupConfigsLvmConfig {\n");
            sb.Append("  lvType: ").Append(LvType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecModelVolumeGroupConfigsLvmConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecModelVolumeGroupConfigsLvmConfig input)
        {
            if (input == null) return false;
            if (this.LvType != input.LvType || (this.LvType != null && !this.LvType.Equals(input.LvType))) return false;

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
                if (this.LvType != null) hashCode = hashCode * 59 + this.LvType.GetHashCode();
                return hashCode;
            }
        }
    }
}
