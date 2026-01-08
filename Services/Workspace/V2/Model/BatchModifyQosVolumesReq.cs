using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量修改磁盘QOS请求。
    /// </summary>
    public class BatchModifyQosVolumesReq 
    {

        /// <summary>
        /// 修改QOS磁盘ids。
        /// </summary>
        [JsonProperty("volume_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qos", NullValueHandling = NullValueHandling.Ignore)]
        public Qos Qos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModifyQosVolumesReq {\n");
            sb.Append("  volumeIds: ").Append(VolumeIds).Append("\n");
            sb.Append("  qos: ").Append(Qos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchModifyQosVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchModifyQosVolumesReq input)
        {
            if (input == null) return false;
            if (this.VolumeIds != input.VolumeIds || (this.VolumeIds != null && input.VolumeIds != null && !this.VolumeIds.SequenceEqual(input.VolumeIds))) return false;
            if (this.Qos != input.Qos || (this.Qos != null && !this.Qos.Equals(input.Qos))) return false;

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
                if (this.VolumeIds != null) hashCode = hashCode * 59 + this.VolumeIds.GetHashCode();
                if (this.Qos != null) hashCode = hashCode * 59 + this.Qos.GetHashCode();
                return hashCode;
            }
        }
    }
}
