using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// The request body of update agency request.
    /// </summary>
    public class UpdateAgencyReqBody 
    {

        /// <summary>
        /// 信任委托最大会话时长，默认为3600秒，取值范围为[3600,43200]。
        /// </summary>
        [JsonProperty("max_session_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSessionDuration { get; set; }

        /// <summary>
        /// 信任委托描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgencyReqBody {\n");
            sb.Append("  maxSessionDuration: ").Append(MaxSessionDuration).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAgencyReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAgencyReqBody input)
        {
            if (input == null) return false;
            if (this.MaxSessionDuration != input.MaxSessionDuration || (this.MaxSessionDuration != null && !this.MaxSessionDuration.Equals(input.MaxSessionDuration))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.MaxSessionDuration != null) hashCode = hashCode * 59 + this.MaxSessionDuration.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
