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
    /// Job的响应信息。
    /// </summary>
    public class JobEntities 
    {

        /// <summary>
        /// 云硬盘的类型。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 云硬盘的容量，单位为GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 云硬盘的ID。
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 云硬盘的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 子Job的信息。当存在子Job信息时，entities中的其他字段将不会返回。
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJob> SubJobs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEntities {\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEntities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubJobs == input.SubJobs ||
                    this.SubJobs != null &&
                    input.SubJobs != null &&
                    this.SubJobs.SequenceEqual(input.SubJobs)
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
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubJobs != null)
                    hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
