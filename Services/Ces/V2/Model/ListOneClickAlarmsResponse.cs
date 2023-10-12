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
    public class ListOneClickAlarmsResponse : SdkResponse
    {

        /// <summary>
        /// 一键告警列表
        /// </summary>
        [JsonProperty("one_click_alarms", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListOneClickAlarmsRespOneClickAlarms> OneClickAlarms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOneClickAlarmsResponse {\n");
            sb.Append("  oneClickAlarms: ").Append(OneClickAlarms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOneClickAlarmsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOneClickAlarmsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OneClickAlarms == input.OneClickAlarms ||
                    this.OneClickAlarms != null &&
                    input.OneClickAlarms != null &&
                    this.OneClickAlarms.SequenceEqual(input.OneClickAlarms)
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
                if (this.OneClickAlarms != null)
                    hashCode = hashCode * 59 + this.OneClickAlarms.GetHashCode();
                return hashCode;
            }
        }
    }
}
