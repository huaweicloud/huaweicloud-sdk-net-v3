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
    public class ListDatastore 
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
        /// 数据库已升级的热补丁版本，当数据库热补丁升级成功后，该值不为空。
        /// </summary>
        [JsonProperty("hotfix_versions", NullValueHandling = NullValueHandling.Ignore)]
        public string HotfixVersions { get; set; }

        /// <summary>
        /// 数据库正在升级的目标版本。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 热补丁升级完成时间列表。  热补丁升级完成时间，格式为“yyyy-mm-dd hh:mm:ss timezone”。  其中timezone是指时区。 
        /// </summary>
        [JsonProperty("hotfix_finished_times", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HotfixFinishedTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatastore {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  completeVersion: ").Append(CompleteVersion).Append("\n");
            sb.Append("  hotfixVersions: ").Append(HotfixVersions).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  hotfixFinishedTimes: ").Append(HotfixFinishedTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatastore);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatastore input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.CompleteVersion != input.CompleteVersion || (this.CompleteVersion != null && !this.CompleteVersion.Equals(input.CompleteVersion))) return false;
            if (this.HotfixVersions != input.HotfixVersions || (this.HotfixVersions != null && !this.HotfixVersions.Equals(input.HotfixVersions))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.HotfixFinishedTimes != input.HotfixFinishedTimes || (this.HotfixFinishedTimes != null && input.HotfixFinishedTimes != null && !this.HotfixFinishedTimes.SequenceEqual(input.HotfixFinishedTimes))) return false;

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
                if (this.HotfixVersions != null) hashCode = hashCode * 59 + this.HotfixVersions.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.HotfixFinishedTimes != null) hashCode = hashCode * 59 + this.HotfixFinishedTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
