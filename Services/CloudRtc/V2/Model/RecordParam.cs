using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 录制参数
    /// </summary>
    public class RecordParam 
    {

        /// <summary>
        /// 录制规则id。
        /// </summary>
        [JsonProperty("record_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordParam {\n");
            sb.Append("  recordRuleId: ").Append(RecordRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordParam input)
        {
            if (input == null) return false;
            if (this.RecordRuleId != input.RecordRuleId || (this.RecordRuleId != null && !this.RecordRuleId.Equals(input.RecordRuleId))) return false;

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
                if (this.RecordRuleId != null) hashCode = hashCode * 59 + this.RecordRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
