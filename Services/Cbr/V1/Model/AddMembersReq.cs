using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 备份共享目标用户的信息。
    /// </summary>
    public class AddMembersReq 
    {

        /// <summary>
        /// 列表，待添加备份共享成员的project_id。
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Members { get; set; }

        /// <summary>
        /// 列表，待添加备份共享成员的domain_id。 &gt; 该特性目前属于公测阶段，部分region可能无法使用.
        /// </summary>
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Domains { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMembersReq {\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  domains: ").Append(Domains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddMembersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddMembersReq input)
        {
            if (input == null) return false;
            if (this.Members != input.Members || (this.Members != null && input.Members != null && !this.Members.SequenceEqual(input.Members))) return false;
            if (this.Domains != input.Domains || (this.Domains != null && input.Domains != null && !this.Domains.SequenceEqual(input.Domains))) return false;

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
                if (this.Members != null) hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Domains != null) hashCode = hashCode * 59 + this.Domains.GetHashCode();
                return hashCode;
            }
        }
    }
}
