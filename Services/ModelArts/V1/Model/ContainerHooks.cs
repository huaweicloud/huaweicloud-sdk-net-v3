using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ContainerHooks 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("post_start", NullValueHandling = NullValueHandling.Ignore)]
        public Config PostStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pre_start", NullValueHandling = NullValueHandling.Ignore)]
        public Config PreStart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerHooks {\n");
            sb.Append("  postStart: ").Append(PostStart).Append("\n");
            sb.Append("  preStart: ").Append(PreStart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContainerHooks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContainerHooks input)
        {
            if (input == null) return false;
            if (this.PostStart != input.PostStart || (this.PostStart != null && !this.PostStart.Equals(input.PostStart))) return false;
            if (this.PreStart != input.PreStart || (this.PreStart != null && !this.PreStart.Equals(input.PreStart))) return false;

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
                if (this.PostStart != null) hashCode = hashCode * 59 + this.PostStart.GetHashCode();
                if (this.PreStart != null) hashCode = hashCode * 59 + this.PreStart.GetHashCode();
                return hashCode;
            }
        }
    }
}
