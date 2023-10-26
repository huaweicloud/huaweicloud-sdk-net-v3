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
    /// Response Object
    /// </summary>
    public class ListNotifiedHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 告警流水号
        /// </summary>
        [JsonProperty("event_sn", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSn { get; set; }

        /// <summary>
        /// 通知结果
        /// </summary>
        [JsonProperty("notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notifications> Notifications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotifiedHistoriesResponse {\n");
            sb.Append("  eventSn: ").Append(EventSn).Append("\n");
            sb.Append("  notifications: ").Append(Notifications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotifiedHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotifiedHistoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventSn == input.EventSn ||
                    (this.EventSn != null &&
                    this.EventSn.Equals(input.EventSn))
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
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
                if (this.EventSn != null)
                    hashCode = hashCode * 59 + this.EventSn.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                return hashCode;
            }
        }
    }
}
