using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSessionRequestBody 
    {

        /// <summary>
        /// 需要终结的会话ID列表。
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sessions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSessionRequestBody {\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSessionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSessionRequestBody input)
        {
            if (input == null) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && input.Sessions != null && !this.Sessions.SequenceEqual(input.Sessions))) return false;

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
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                return hashCode;
            }
        }
    }
}
