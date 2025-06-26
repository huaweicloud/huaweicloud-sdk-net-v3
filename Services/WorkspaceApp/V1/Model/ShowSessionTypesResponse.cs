using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSessionTypesResponse : SdkResponse
    {

        /// <summary>
        /// 会话列表。
        /// </summary>
        [JsonProperty("session_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionTypeEntity> SessionTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSessionTypesResponse {\n");
            sb.Append("  sessionTypes: ").Append(SessionTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSessionTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSessionTypesResponse input)
        {
            if (input == null) return false;
            if (this.SessionTypes != input.SessionTypes || (this.SessionTypes != null && input.SessionTypes != null && !this.SessionTypes.SequenceEqual(input.SessionTypes))) return false;

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
                if (this.SessionTypes != null) hashCode = hashCode * 59 + this.SessionTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
