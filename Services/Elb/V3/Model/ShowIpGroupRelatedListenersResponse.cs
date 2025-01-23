using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIpGroupRelatedListenersResponse : SdkResponse
    {

        /// <summary>
        /// IP地址组关联的所有监听器ID列表
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerRef> Listeners { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpGroupRelatedListenersResponse {\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpGroupRelatedListenersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpGroupRelatedListenersResponse input)
        {
            if (input == null) return false;
            if (this.Listeners != input.Listeners || (this.Listeners != null && input.Listeners != null && !this.Listeners.SequenceEqual(input.Listeners))) return false;

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
                if (this.Listeners != null) hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                return hashCode;
            }
        }
    }
}
