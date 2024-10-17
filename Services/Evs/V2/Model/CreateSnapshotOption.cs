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
    /// 快照信息。
    /// </summary>
    public class CreateSnapshotOption 
    {

        /// <summary>
        /// 源云硬盘的ID。
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 强制创快照标示，默认为false。 当force标记为false时，云硬盘处于挂载状态时，不能强制创建快照。 当force标记为true时，即使云硬盘处于挂载状态时，仍可以创建快照。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// 云硬盘快照的元数据信息。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 云硬盘快照描述，最大支持255个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 云硬盘快照名称。最大支持255个字节。  &gt; &gt; 说明： &gt; 对云硬盘创建备份时，同时会创建以autobk_snapshot_为名称前缀的快照，云硬盘控制台对此类快照会有操作限制。因此建议不要创建以&gt; &gt; autobk_snapshot_为名称前缀的快照，避免影响快照的正常使用
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSnapshotOption {\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSnapshotOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSnapshotOption input)
        {
            if (input == null) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.Force != input.Force || (this.Force != null && !this.Force.Equals(input.Force))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Force != null) hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
