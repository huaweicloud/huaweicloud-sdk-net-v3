using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmTemplateAssociationAlarmsResponse : SdkResponse
    {

        /// <summary>
        /// 告警规则列表
        /// </summary>
        [JsonProperty("alarms", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListAssociationAlarmsResponseAlarms> Alarms { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则列表总数。     **取值范围**： 取值范围为0-1000. 
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplateAssociationAlarmsResponse {\n");
            sb.Append("  alarms: ").Append(Alarms).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplateAssociationAlarmsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplateAssociationAlarmsResponse input)
        {
            if (input == null) return false;
            if (this.Alarms != input.Alarms || (this.Alarms != null && input.Alarms != null && !this.Alarms.SequenceEqual(input.Alarms))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.Alarms != null) hashCode = hashCode * 59 + this.Alarms.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
