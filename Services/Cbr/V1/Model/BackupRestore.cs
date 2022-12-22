using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupRestore 
    {

        /// <summary>
        /// 恢复的映射关系(整机恢复时必填，卷恢复时可选但是不会用到填写的值）
        /// </summary>
        [JsonProperty("mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupRestoreServerMapping> Mappings { get; set; }

        /// <summary>
        /// 恢复后是否开始，默认开机。
        /// </summary>
        [JsonProperty("power_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PowerOn { get; set; }

        /// <summary>
        /// 恢复的目标虚拟机ID（整机恢复时必填）
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 恢复的目标卷ID（卷恢复时必填）
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 待恢复的目标资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRestore {\n");
            sb.Append("  mappings: ").Append(Mappings).Append("\n");
            sb.Append("  powerOn: ").Append(PowerOn).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupRestore);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupRestore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
                ) && 
                (
                    this.PowerOn == input.PowerOn ||
                    (this.PowerOn != null &&
                    this.PowerOn.Equals(input.PowerOn))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                if (this.PowerOn != null)
                    hashCode = hashCode * 59 + this.PowerOn.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
