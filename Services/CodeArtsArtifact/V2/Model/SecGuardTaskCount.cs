using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SecGuardTaskCount 
    {

        /// <summary>
        /// **参数解释**: 扫描次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public int? Task { get; set; }

        /// <summary>
        /// **参数解释**: 扫描制品数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("artifact", NullValueHandling = NullValueHandling.Ignore)]
        public int? Artifact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("opensource", NullValueHandling = NullValueHandling.Ignore)]
        public OpensourceCount Opensource { get; set; }

        /// <summary>
        /// **参数解释**: 病毒文件数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("virus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Virus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("malware", NullValueHandling = NullValueHandling.Ignore)]
        public MalwareCount Malware { get; set; }

        /// <summary>
        /// **参数解释**: 扫描总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 扫描任务列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecGuardTaskDetail> List { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecGuardTaskCount {\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  artifact: ").Append(Artifact).Append("\n");
            sb.Append("  opensource: ").Append(Opensource).Append("\n");
            sb.Append("  virus: ").Append(Virus).Append("\n");
            sb.Append("  malware: ").Append(Malware).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecGuardTaskCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecGuardTaskCount input)
        {
            if (input == null) return false;
            if (this.Task != input.Task || (this.Task != null && !this.Task.Equals(input.Task))) return false;
            if (this.Artifact != input.Artifact || (this.Artifact != null && !this.Artifact.Equals(input.Artifact))) return false;
            if (this.Opensource != input.Opensource || (this.Opensource != null && !this.Opensource.Equals(input.Opensource))) return false;
            if (this.Virus != input.Virus || (this.Virus != null && !this.Virus.Equals(input.Virus))) return false;
            if (this.Malware != input.Malware || (this.Malware != null && !this.Malware.Equals(input.Malware))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;

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
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.Artifact != null) hashCode = hashCode * 59 + this.Artifact.GetHashCode();
                if (this.Opensource != null) hashCode = hashCode * 59 + this.Opensource.GetHashCode();
                if (this.Virus != null) hashCode = hashCode * 59 + this.Virus.GetHashCode();
                if (this.Malware != null) hashCode = hashCode * 59 + this.Malware.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }
}
