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
    /// **参数解释**：磁盘高级配置信息。
    /// </summary>
    public class PoolSpecModelVolumeGroupConfigs 
    {

        /// <summary>
        /// **参数解释**：磁盘分组名称。作为dataVolumes中volumeGroup的索引。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("volumeGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeGroup { get; set; }

        /// <summary>
        /// **参数解释**：资源池节点容器盘占数据盘的百分比。仅磁盘分组名称为vgpaas时，即容器盘，才可指定此参数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("dockerThinPool", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerThinPool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lvmConfig", NullValueHandling = NullValueHandling.Ignore)]
        public PoolSpecModelVolumeGroupConfigsLvmConfig LvmConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecModelVolumeGroupConfigs {\n");
            sb.Append("  volumeGroup: ").Append(VolumeGroup).Append("\n");
            sb.Append("  dockerThinPool: ").Append(DockerThinPool).Append("\n");
            sb.Append("  lvmConfig: ").Append(LvmConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecModelVolumeGroupConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecModelVolumeGroupConfigs input)
        {
            if (input == null) return false;
            if (this.VolumeGroup != input.VolumeGroup || (this.VolumeGroup != null && !this.VolumeGroup.Equals(input.VolumeGroup))) return false;
            if (this.DockerThinPool != input.DockerThinPool || (this.DockerThinPool != null && !this.DockerThinPool.Equals(input.DockerThinPool))) return false;
            if (this.LvmConfig != input.LvmConfig || (this.LvmConfig != null && !this.LvmConfig.Equals(input.LvmConfig))) return false;

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
                if (this.VolumeGroup != null) hashCode = hashCode * 59 + this.VolumeGroup.GetHashCode();
                if (this.DockerThinPool != null) hashCode = hashCode * 59 + this.DockerThinPool.GetHashCode();
                if (this.LvmConfig != null) hashCode = hashCode * 59 + this.LvmConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
