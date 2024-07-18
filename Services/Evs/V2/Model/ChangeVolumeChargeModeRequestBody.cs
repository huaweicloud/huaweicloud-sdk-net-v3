using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ChangeVolumeChargeModeRequestBody 
    {

        /// <summary>
        /// 要修改计费模式的云硬盘id列表，可以填写多个
        /// </summary>
        [JsonProperty("volume_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// 云硬盘所挂载的虚拟机id, 如果volume_ids中没有多挂载的共享云硬盘，则此参数可无需填写。
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public BssParam2 BssParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeVolumeChargeModeRequestBody {\n");
            sb.Append("  volumeIds: ").Append(VolumeIds).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeVolumeChargeModeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeVolumeChargeModeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeIds == input.VolumeIds ||
                    this.VolumeIds != null &&
                    input.VolumeIds != null &&
                    this.VolumeIds.SequenceEqual(input.VolumeIds)
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
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
                if (this.VolumeIds != null)
                    hashCode = hashCode * 59 + this.VolumeIds.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
