using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 实例专属存储信息。
    /// </summary>
    public class DssPoolInfo 
    {

        /// <summary>
        /// 专属存储池所在az
        /// </summary>
        [JsonProperty("az_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AzName { get; set; }

        /// <summary>
        /// 专属存储池免费空间大小，单位GB
        /// </summary>
        [JsonProperty("free_capacity_gb", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeCapacityGb { get; set; }

        /// <summary>
        /// 专属存储池磁盘类型名称，可能取值如下：  - ULTRAHIGH，表示SSD。
        /// </summary>
        [JsonProperty("dss_pool_volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DssPoolVolumeType { get; set; }

        /// <summary>
        /// 专属存储池ID
        /// </summary>
        [JsonProperty("dss_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DssPoolId { get; set; }

        /// <summary>
        /// 专属存储池当前状态，可能取值如下： - available，表示可用。 - deploying，表示正在部署。 - enlarging，表示正在扩容。 - frozen，表示冻结。 - sellout，表示售罄。
        /// </summary>
        [JsonProperty("dss_pool_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DssPoolStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DssPoolInfo {\n");
            sb.Append("  azName: ").Append(AzName).Append("\n");
            sb.Append("  freeCapacityGb: ").Append(FreeCapacityGb).Append("\n");
            sb.Append("  dssPoolVolumeType: ").Append(DssPoolVolumeType).Append("\n");
            sb.Append("  dssPoolId: ").Append(DssPoolId).Append("\n");
            sb.Append("  dssPoolStatus: ").Append(DssPoolStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DssPoolInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DssPoolInfo input)
        {
            if (input == null) return false;
            if (this.AzName != input.AzName || (this.AzName != null && !this.AzName.Equals(input.AzName))) return false;
            if (this.FreeCapacityGb != input.FreeCapacityGb || (this.FreeCapacityGb != null && !this.FreeCapacityGb.Equals(input.FreeCapacityGb))) return false;
            if (this.DssPoolVolumeType != input.DssPoolVolumeType || (this.DssPoolVolumeType != null && !this.DssPoolVolumeType.Equals(input.DssPoolVolumeType))) return false;
            if (this.DssPoolId != input.DssPoolId || (this.DssPoolId != null && !this.DssPoolId.Equals(input.DssPoolId))) return false;
            if (this.DssPoolStatus != input.DssPoolStatus || (this.DssPoolStatus != null && !this.DssPoolStatus.Equals(input.DssPoolStatus))) return false;

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
                if (this.AzName != null) hashCode = hashCode * 59 + this.AzName.GetHashCode();
                if (this.FreeCapacityGb != null) hashCode = hashCode * 59 + this.FreeCapacityGb.GetHashCode();
                if (this.DssPoolVolumeType != null) hashCode = hashCode * 59 + this.DssPoolVolumeType.GetHashCode();
                if (this.DssPoolId != null) hashCode = hashCode * 59 + this.DssPoolId.GetHashCode();
                if (this.DssPoolStatus != null) hashCode = hashCode * 59 + this.DssPoolStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
