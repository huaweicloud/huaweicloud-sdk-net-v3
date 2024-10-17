using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRepoDomainsRequestBody 
    {

        /// <summary>
        /// 当前只支持read权限
        /// </summary>
        [JsonProperty("permit", NullValueHandling = NullValueHandling.Ignore)]
        public string Permit { get; set; }

        /// <summary>
        /// 截止时间，UTC时间格式。永久有效为forever
        /// </summary>
        [JsonProperty("deadline", NullValueHandling = NullValueHandling.Ignore)]
        public string Deadline { get; set; }

        /// <summary>
        /// 描述。默认值为空字符串
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepoDomainsRequestBody {\n");
            sb.Append("  permit: ").Append(Permit).Append("\n");
            sb.Append("  deadline: ").Append(Deadline).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepoDomainsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepoDomainsRequestBody input)
        {
            if (input == null) return false;
            if (this.Permit != input.Permit || (this.Permit != null && !this.Permit.Equals(input.Permit))) return false;
            if (this.Deadline != input.Deadline || (this.Deadline != null && !this.Deadline.Equals(input.Deadline))) return false;
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
                if (this.Permit != null) hashCode = hashCode * 59 + this.Permit.GetHashCode();
                if (this.Deadline != null) hashCode = hashCode * 59 + this.Deadline.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
