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
    /// Response Object
    /// </summary>
    public class ListKeywordsAlarmRulesResponse : SdkResponse
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("keywords_alarm_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeywordsAlarmRuleRespList> KeywordsAlarmRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeywordsAlarmRulesResponse {\n");
            sb.Append("  keywordsAlarmRules: ").Append(KeywordsAlarmRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeywordsAlarmRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeywordsAlarmRulesResponse input)
        {
            if (input == null) return false;
            if (this.KeywordsAlarmRules != input.KeywordsAlarmRules || (this.KeywordsAlarmRules != null && input.KeywordsAlarmRules != null && !this.KeywordsAlarmRules.SequenceEqual(input.KeywordsAlarmRules))) return false;

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
                if (this.KeywordsAlarmRules != null) hashCode = hashCode * 59 + this.KeywordsAlarmRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
