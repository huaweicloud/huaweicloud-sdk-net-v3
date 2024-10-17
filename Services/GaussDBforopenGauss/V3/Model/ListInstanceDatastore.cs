using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class ListInstanceDatastore 
    {

        /// <summary>
        /// 数据库引擎。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库大版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 数据库小版本。
        /// </summary>
        [JsonProperty("complete_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CompleteVersion { get; set; }

        /// <summary>
        /// 数据库正在升级的目标版本。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 数据库内核版本
        /// </summary>
        [JsonProperty("complete_kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CompleteKernelVersion { get; set; }

        /// <summary>
        /// 热补丁信息列表
        /// </summary>
        [JsonProperty("hotfix_version_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<HotfixVersionInfo> HotfixVersionInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceDatastore {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  completeVersion: ").Append(CompleteVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  completeKernelVersion: ").Append(CompleteKernelVersion).Append("\n");
            sb.Append("  hotfixVersionInfos: ").Append(HotfixVersionInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceDatastore);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceDatastore input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.CompleteVersion != input.CompleteVersion || (this.CompleteVersion != null && !this.CompleteVersion.Equals(input.CompleteVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.CompleteKernelVersion != input.CompleteKernelVersion || (this.CompleteKernelVersion != null && !this.CompleteKernelVersion.Equals(input.CompleteKernelVersion))) return false;
            if (this.HotfixVersionInfos != input.HotfixVersionInfos || (this.HotfixVersionInfos != null && input.HotfixVersionInfos != null && !this.HotfixVersionInfos.SequenceEqual(input.HotfixVersionInfos))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CompleteVersion != null) hashCode = hashCode * 59 + this.CompleteVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.CompleteKernelVersion != null) hashCode = hashCode * 59 + this.CompleteKernelVersion.GetHashCode();
                if (this.HotfixVersionInfos != null) hashCode = hashCode * 59 + this.HotfixVersionInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
