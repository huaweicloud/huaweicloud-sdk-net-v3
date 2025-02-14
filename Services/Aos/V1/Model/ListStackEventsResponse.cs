using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStackEventsResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈事件列表
        /// </summary>
        [JsonProperty("stack_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackEvent> StackEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackEventsResponse {\n");
            sb.Append("  stackEvents: ").Append(StackEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackEventsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackEventsResponse input)
        {
            if (input == null) return false;
            if (this.StackEvents != input.StackEvents || (this.StackEvents != null && input.StackEvents != null && !this.StackEvents.SequenceEqual(input.StackEvents))) return false;

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
                if (this.StackEvents != null) hashCode = hashCode * 59 + this.StackEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
