using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 源数据
    /// </summary>
    public class Event2alarmRuleBodyMetadata 
    {

        /// <summary>
        /// 用户自定义标签
        /// </summary>
        [JsonProperty("customField", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomField { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event2alarmRuleBodyMetadata {\n");
            sb.Append("  customField: ").Append(CustomField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event2alarmRuleBodyMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event2alarmRuleBodyMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomField == input.CustomField ||
                    this.CustomField != null &&
                    input.CustomField != null &&
                    this.CustomField.SequenceEqual(input.CustomField)
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
                if (this.CustomField != null)
                    hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                return hashCode;
            }
        }
    }
}
