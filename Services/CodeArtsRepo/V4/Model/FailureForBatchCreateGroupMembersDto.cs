using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 关联失败成员
    /// </summary>
    public class FailureForBatchCreateGroupMembersDto 
    {

        /// <summary>
        /// iam_id
        /// </summary>
        [JsonProperty("iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamId { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailureForBatchCreateGroupMembersDto {\n");
            sb.Append("  iamId: ").Append(IamId).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailureForBatchCreateGroupMembersDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailureForBatchCreateGroupMembersDto input)
        {
            if (input == null) return false;
            if (this.IamId != input.IamId || (this.IamId != null && !this.IamId.Equals(input.IamId))) return false;
            if (this.Message != input.Message || (this.Message != null && input.Message != null && !this.Message.SequenceEqual(input.Message))) return false;

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
                if (this.IamId != null) hashCode = hashCode * 59 + this.IamId.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
