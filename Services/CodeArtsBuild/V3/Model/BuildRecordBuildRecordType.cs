using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 构建记录类型
    /// </summary>
    public class BuildRecordBuildRecordType 
    {

        /// <summary>
        /// 是否rerun
        /// </summary>
        [JsonProperty("rerun", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rerun { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// 是否返回
        /// </summary>
        [JsonProperty("is_rerun", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRerun { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildRecordBuildRecordType {\n");
            sb.Append("  rerun: ").Append(Rerun).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  isRerun: ").Append(IsRerun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildRecordBuildRecordType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildRecordBuildRecordType input)
        {
            if (input == null) return false;
            if (this.Rerun != input.Rerun || (this.Rerun != null && !this.Rerun.Equals(input.Rerun))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;
            if (this.IsRerun != input.IsRerun || (this.IsRerun != null && !this.IsRerun.Equals(input.IsRerun))) return false;

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
                if (this.Rerun != null) hashCode = hashCode * 59 + this.Rerun.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.RecordType != null) hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.IsRerun != null) hashCode = hashCode * 59 + this.IsRerun.GetHashCode();
                return hashCode;
            }
        }
    }
}
