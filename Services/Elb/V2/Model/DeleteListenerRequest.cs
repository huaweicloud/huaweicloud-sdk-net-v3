using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteListenerRequest 
    {

        /// <summary>
        /// 监听器id
        /// </summary>
        [SDKProperty("listener_id", IsPath = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteListenerRequest {\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteListenerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteListenerRequest input)
        {
            if (input == null) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && !this.ListenerId.Equals(input.ListenerId))) return false;

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
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
