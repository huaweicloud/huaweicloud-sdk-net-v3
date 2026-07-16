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
    /// 
    /// </summary>
    public class PoolSpecModelResources 
    {

        /// <summary>
        /// **参数解释**：资源规格ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：资源池中资源规格实例数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：资源规格的弹性资源量。物理池中该值和count必须一致。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("maxCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// **参数解释**：资源池中期望创建的资源规格实例的az分布。
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolNodeAz> Azs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParams", NullValueHandling = NullValueHandling.Ignore)]
        public PoolSpecModelExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public Os Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public PoolSpecModelDataVolumes DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumeGroupConfigs", NullValueHandling = NullValueHandling.Ignore)]
        public PoolSpecModelVolumeGroupConfigs VolumeGroupConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecModelResources {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  maxCount: ").Append(MaxCount).Append("\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  volumeGroupConfigs: ").Append(VolumeGroupConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecModelResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecModelResources input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.MaxCount != input.MaxCount || (this.MaxCount != null && !this.MaxCount.Equals(input.MaxCount))) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && !this.DataVolumes.Equals(input.DataVolumes))) return false;
            if (this.VolumeGroupConfigs != input.VolumeGroupConfigs || (this.VolumeGroupConfigs != null && !this.VolumeGroupConfigs.Equals(input.VolumeGroupConfigs))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.MaxCount != null) hashCode = hashCode * 59 + this.MaxCount.GetHashCode();
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.VolumeGroupConfigs != null) hashCode = hashCode * 59 + this.VolumeGroupConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
