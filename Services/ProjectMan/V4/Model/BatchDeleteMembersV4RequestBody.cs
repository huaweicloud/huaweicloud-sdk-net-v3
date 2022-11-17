using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteMembersV4RequestBody 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteMembersV4RequestBody {\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteMembersV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteMembersV4RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
