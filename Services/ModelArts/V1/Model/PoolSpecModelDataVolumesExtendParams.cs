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
    /// **参数解释**：磁盘自定义配置
    /// </summary>
    public class PoolSpecModelDataVolumesExtendParams 
    {

        /// <summary>
        /// **参数解释**：标识存储实例是否计费。为空则表示不计费。该字段用户不可指定或修改。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public string Billing { get; set; }

        /// <summary>
        /// **参数解释**：磁盘分组名称，用于各个存储空间的划分。 **取值范围**：可选项如下： - vgpaas：容器盘。 - default：普通数据盘，以默认方式挂载。 - vguser{num}：普通数据盘，指定挂载路径，不同路径的分组名称不同，如vguser1，vguser2。 - vg-everest-localvolume-persistent：普通数据盘，作为持久存储卷 - vg-everest-localvolume-ephemeral：普通数据盘，作为临时存储卷
        /// </summary>
        [JsonProperty("volumeGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecModelDataVolumesExtendParams {\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  volumeGroup: ").Append(VolumeGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecModelDataVolumesExtendParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecModelDataVolumesExtendParams input)
        {
            if (input == null) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.VolumeGroup != input.VolumeGroup || (this.VolumeGroup != null && !this.VolumeGroup.Equals(input.VolumeGroup))) return false;

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
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.VolumeGroup != null) hashCode = hashCode * 59 + this.VolumeGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
