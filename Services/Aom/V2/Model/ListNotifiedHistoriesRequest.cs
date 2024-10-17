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
    /// Request Object
    /// </summary>
    public class ListNotifiedHistoriesRequest 
    {

        /// <summary>
        /// 告警流水号
        /// </summary>
        [SDKProperty("event_sn", IsQuery = true)]
        [JsonProperty("event_sn", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotifiedHistoriesRequest {\n");
            sb.Append("  eventSn: ").Append(EventSn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotifiedHistoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotifiedHistoriesRequest input)
        {
            if (input == null) return false;
            if (this.EventSn != input.EventSn || (this.EventSn != null && !this.EventSn.Equals(input.EventSn))) return false;

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
                if (this.EventSn != null) hashCode = hashCode * 59 + this.EventSn.GetHashCode();
                return hashCode;
            }
        }
    }
}
