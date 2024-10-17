using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// InviteAccount 操作的请求体。
    /// </summary>
    public class InviteAccountReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public TargetDto Target { get; set; }

        /// <summary>
        /// 给收件账号所有者的邮件中的附加信息。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// 要绑定到新创建的账号的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagDto> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteAccountReqBody {\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InviteAccountReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InviteAccountReqBody input)
        {
            if (input == null) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
