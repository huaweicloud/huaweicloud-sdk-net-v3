using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowServerResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public ServerDetail Server { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerResponse {\n");
            sb.Append("  server: ").Append(Server).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerResponse input)
        {
            if (input == null) return false;
            if (this.Server != input.Server || (this.Server != null && !this.Server.Equals(input.Server))) return false;

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
                if (this.Server != null) hashCode = hashCode * 59 + this.Server.GetHashCode();
                return hashCode;
            }
        }
    }
}
