using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteInstancesSessionRequestBody 
    {

        /// <summary>
        /// 是否删除全部会话。
        /// </summary>
        [JsonProperty("is_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAll { get; set; }

        /// <summary>
        /// 需要删除的会话id。is_all为false的时候，session_ids为必填，不能为空。
        /// </summary>
        [JsonProperty("session_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SessionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInstancesSessionRequestBody {\n");
            sb.Append("  isAll: ").Append(IsAll).Append("\n");
            sb.Append("  sessionIds: ").Append(SessionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInstancesSessionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInstancesSessionRequestBody input)
        {
            if (input == null) return false;
            if (this.IsAll != input.IsAll || (this.IsAll != null && !this.IsAll.Equals(input.IsAll))) return false;
            if (this.SessionIds != input.SessionIds || (this.SessionIds != null && input.SessionIds != null && !this.SessionIds.SequenceEqual(input.SessionIds))) return false;

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
                if (this.IsAll != null) hashCode = hashCode * 59 + this.IsAll.GetHashCode();
                if (this.SessionIds != null) hashCode = hashCode * 59 + this.SessionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
