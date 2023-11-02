using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 数据库版本信息。
    /// </summary>
    public class InstanceDatabaseVersionInfo 
    {

        /// <summary>
        /// 当前数据库版本。
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 当前数据库内核版本。
        /// </summary>
        [JsonProperty("current_kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentKernelVersion { get; set; }

        /// <summary>
        /// 最新数据库版本。
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// 最新数据库内核版本。
        /// </summary>
        [JsonProperty("latest_kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestKernelVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDatabaseVersionInfo {\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  currentKernelVersion: ").Append(CurrentKernelVersion).Append("\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  latestKernelVersion: ").Append(LatestKernelVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDatabaseVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDatabaseVersionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
                ) && 
                (
                    this.CurrentKernelVersion == input.CurrentKernelVersion ||
                    (this.CurrentKernelVersion != null &&
                    this.CurrentKernelVersion.Equals(input.CurrentKernelVersion))
                ) && 
                (
                    this.LatestVersion == input.LatestVersion ||
                    (this.LatestVersion != null &&
                    this.LatestVersion.Equals(input.LatestVersion))
                ) && 
                (
                    this.LatestKernelVersion == input.LatestKernelVersion ||
                    (this.LatestKernelVersion != null &&
                    this.LatestKernelVersion.Equals(input.LatestKernelVersion))
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
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.CurrentKernelVersion != null)
                    hashCode = hashCode * 59 + this.CurrentKernelVersion.GetHashCode();
                if (this.LatestVersion != null)
                    hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.LatestKernelVersion != null)
                    hashCode = hashCode * 59 + this.LatestKernelVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
