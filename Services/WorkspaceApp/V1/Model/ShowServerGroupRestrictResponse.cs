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
    public class ShowServerGroupRestrictResponse : SdkResponse
    {

        /// <summary>
        /// 单台服务器最大的链接会话数。
        /// </summary>
        [JsonProperty("max_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSession { get; set; }

        /// <summary>
        /// 该租户可创建的最多服务器组数量。
        /// </summary>
        [JsonProperty("max_group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxGroupCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerGroupRestrictResponse {\n");
            sb.Append("  maxSession: ").Append(MaxSession).Append("\n");
            sb.Append("  maxGroupCount: ").Append(MaxGroupCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerGroupRestrictResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerGroupRestrictResponse input)
        {
            if (input == null) return false;
            if (this.MaxSession != input.MaxSession || (this.MaxSession != null && !this.MaxSession.Equals(input.MaxSession))) return false;
            if (this.MaxGroupCount != input.MaxGroupCount || (this.MaxGroupCount != null && !this.MaxGroupCount.Equals(input.MaxGroupCount))) return false;

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
                if (this.MaxSession != null) hashCode = hashCode * 59 + this.MaxSession.GetHashCode();
                if (this.MaxGroupCount != null) hashCode = hashCode * 59 + this.MaxGroupCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
