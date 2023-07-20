using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
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
        /// 专属存储池磁盘类型名称，可能取值如下：  - ULTRAHIGH，表示SSD。  - LOCALSSD：表示本地SSD。  - CLOUDSSD：表示SSD云盘，仅支持通用型和独享型规格实例。  - ESSD：表示极速型SSD，仅支持独享型规格实例。
        /// </summary>
        [JsonProperty("dsspool_volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DsspoolVolumeType { get; set; }

        /// <summary>
        /// 专属存储池ID
        /// </summary>
        [JsonProperty("dsspool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DsspoolId { get; set; }

        /// <summary>
        /// 专属存储池当前状态，可能取值如下： - available，表示可用。 - deploying，表示正在部署。 - enlarging，表示正在扩容。 - frozen，表示冻结。 - sellout，表示售罄。
        /// </summary>
        [JsonProperty("dsspool_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DsspoolStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DssPoolInfo {\n");
            sb.Append("  azName: ").Append(AzName).Append("\n");
            sb.Append("  freeCapacityGb: ").Append(FreeCapacityGb).Append("\n");
            sb.Append("  dsspoolVolumeType: ").Append(DsspoolVolumeType).Append("\n");
            sb.Append("  dsspoolId: ").Append(DsspoolId).Append("\n");
            sb.Append("  dsspoolStatus: ").Append(DsspoolStatus).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.AzName == input.AzName ||
                    (this.AzName != null &&
                    this.AzName.Equals(input.AzName))
                ) && 
                (
                    this.FreeCapacityGb == input.FreeCapacityGb ||
                    (this.FreeCapacityGb != null &&
                    this.FreeCapacityGb.Equals(input.FreeCapacityGb))
                ) && 
                (
                    this.DsspoolVolumeType == input.DsspoolVolumeType ||
                    (this.DsspoolVolumeType != null &&
                    this.DsspoolVolumeType.Equals(input.DsspoolVolumeType))
                ) && 
                (
                    this.DsspoolId == input.DsspoolId ||
                    (this.DsspoolId != null &&
                    this.DsspoolId.Equals(input.DsspoolId))
                ) && 
                (
                    this.DsspoolStatus == input.DsspoolStatus ||
                    (this.DsspoolStatus != null &&
                    this.DsspoolStatus.Equals(input.DsspoolStatus))
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
                if (this.AzName != null)
                    hashCode = hashCode * 59 + this.AzName.GetHashCode();
                if (this.FreeCapacityGb != null)
                    hashCode = hashCode * 59 + this.FreeCapacityGb.GetHashCode();
                if (this.DsspoolVolumeType != null)
                    hashCode = hashCode * 59 + this.DsspoolVolumeType.GetHashCode();
                if (this.DsspoolId != null)
                    hashCode = hashCode * 59 + this.DsspoolId.GetHashCode();
                if (this.DsspoolStatus != null)
                    hashCode = hashCode * 59 + this.DsspoolStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
