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
    public class ShowServerLimitsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("absolute", NullValueHandling = NullValueHandling.Ignore)]
        public ServerLimits Absolute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerLimitsResponse {\n");
            sb.Append("  absolute: ").Append(Absolute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerLimitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerLimitsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Absolute == input.Absolute ||
                    (this.Absolute != null &&
                    this.Absolute.Equals(input.Absolute))
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
                if (this.Absolute != null)
                    hashCode = hashCode * 59 + this.Absolute.GetHashCode();
                return hashCode;
            }
        }
    }
}
