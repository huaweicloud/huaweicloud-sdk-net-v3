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
    public class CreateOneClickAlarmResponse : SdkResponse
    {

        /// <summary>
        /// 一键告警ID
        /// </summary>
        [JsonProperty("one_click_alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OneClickAlarmId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOneClickAlarmResponse {\n");
            sb.Append("  oneClickAlarmId: ").Append(OneClickAlarmId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOneClickAlarmResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOneClickAlarmResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OneClickAlarmId == input.OneClickAlarmId ||
                    (this.OneClickAlarmId != null &&
                    this.OneClickAlarmId.Equals(input.OneClickAlarmId))
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
                if (this.OneClickAlarmId != null)
                    hashCode = hashCode * 59 + this.OneClickAlarmId.GetHashCode();
                return hashCode;
            }
        }
    }
}
