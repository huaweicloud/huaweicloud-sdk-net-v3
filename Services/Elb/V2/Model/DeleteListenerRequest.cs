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
        /// 
        /// </summary>
        [SDKProperty("cascade", IsQuery = true)]
        [JsonProperty("cascade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cascade { get; set; }

        /// <summary>
        /// 
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
            sb.Append("  cascade: ").Append(Cascade).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Cascade == input.Cascade ||
                    (this.Cascade != null &&
                    this.Cascade.Equals(input.Cascade))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
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
                if (this.Cascade != null)
                    hashCode = hashCode * 59 + this.Cascade.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
