using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Results 
    {

        /// <summary>
        /// **参数解释：** 企业项目ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// **参数解释：** 日志组名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// **参数解释：** 日志组别名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_group_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupNameAlias { get; set; }

        /// <summary>
        /// **参数解释：** 日志流名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// **参数解释：** 日志流别名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_stream_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamNameAlias { get; set; }

        /// <summary>
        /// **参数解释：** 告警统计周期，例如：1小时。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Results {\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logGroupNameAlias: ").Append(LogGroupNameAlias).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logStreamNameAlias: ").Append(LogStreamNameAlias).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Results);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Results input)
        {
            if (input == null) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogGroupNameAlias != input.LogGroupNameAlias || (this.LogGroupNameAlias != null && !this.LogGroupNameAlias.Equals(input.LogGroupNameAlias))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogStreamNameAlias != input.LogStreamNameAlias || (this.LogStreamNameAlias != null && !this.LogStreamNameAlias.Equals(input.LogStreamNameAlias))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogGroupNameAlias != null) hashCode = hashCode * 59 + this.LogGroupNameAlias.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogStreamNameAlias != null) hashCode = hashCode * 59 + this.LogStreamNameAlias.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
