using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobParameters 
    {

        /// <summary>
        /// 是否删除无tag的制品；默认为false，不删除无tag的制品。
        /// </summary>
        [JsonProperty("delete_untagged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteUntagged { get; set; }

        /// <summary>
        /// 并行执行制品清理任务的工作者数量，最小值为1，最大值为5。
        /// </summary>
        [JsonProperty("workers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Workers { get; set; }

        /// <summary>
        /// 是否模拟执行任务；默认值为false，非模拟运行。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 清理镜像层的个数。
        /// </summary>
        [JsonProperty("purged_blobs", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurgedBlobs { get; set; }

        /// <summary>
        /// 清理镜像manifest的个数。
        /// </summary>
        [JsonProperty("purged_manifests", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurgedManifests { get; set; }

        /// <summary>
        /// 释放的镜像存储空间大小(单位为字节)。
        /// </summary>
        [JsonProperty("freed_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreedSpace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobParameters {\n");
            sb.Append("  deleteUntagged: ").Append(DeleteUntagged).Append("\n");
            sb.Append("  workers: ").Append(Workers).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  purgedBlobs: ").Append(PurgedBlobs).Append("\n");
            sb.Append("  purgedManifests: ").Append(PurgedManifests).Append("\n");
            sb.Append("  freedSpace: ").Append(FreedSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobParameters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobParameters input)
        {
            if (input == null) return false;
            if (this.DeleteUntagged != input.DeleteUntagged || (this.DeleteUntagged != null && !this.DeleteUntagged.Equals(input.DeleteUntagged))) return false;
            if (this.Workers != input.Workers || (this.Workers != null && !this.Workers.Equals(input.Workers))) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;
            if (this.PurgedBlobs != input.PurgedBlobs || (this.PurgedBlobs != null && !this.PurgedBlobs.Equals(input.PurgedBlobs))) return false;
            if (this.PurgedManifests != input.PurgedManifests || (this.PurgedManifests != null && !this.PurgedManifests.Equals(input.PurgedManifests))) return false;
            if (this.FreedSpace != input.FreedSpace || (this.FreedSpace != null && !this.FreedSpace.Equals(input.FreedSpace))) return false;

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
                if (this.DeleteUntagged != null) hashCode = hashCode * 59 + this.DeleteUntagged.GetHashCode();
                if (this.Workers != null) hashCode = hashCode * 59 + this.Workers.GetHashCode();
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.PurgedBlobs != null) hashCode = hashCode * 59 + this.PurgedBlobs.GetHashCode();
                if (this.PurgedManifests != null) hashCode = hashCode * 59 + this.PurgedManifests.GetHashCode();
                if (this.FreedSpace != null) hashCode = hashCode * 59 + this.FreedSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
