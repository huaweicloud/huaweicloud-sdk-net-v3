using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleSpec 
    {

        /// <summary>
        /// 权限策略关联的IAM用户信息
        /// </summary>
        [JsonProperty("iamUserIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IamUserIDs { get; set; }

        /// <summary>
        /// 权限策略类型，只允许四种类型：readonly/develop/admin/custom
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 权限策略内容
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Content> Contents { get; set; }

        /// <summary>
        /// 权限策略描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSpec {\n");
            sb.Append("  iamUserIDs: ").Append(IamUserIDs).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  contents: ").Append(Contents).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleSpec input)
        {
            if (input == null) return false;
            if (this.IamUserIDs != input.IamUserIDs || (this.IamUserIDs != null && input.IamUserIDs != null && !this.IamUserIDs.SequenceEqual(input.IamUserIDs))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Contents != input.Contents || (this.Contents != null && input.Contents != null && !this.Contents.SequenceEqual(input.Contents))) return false;
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
                if (this.IamUserIDs != null) hashCode = hashCode * 59 + this.IamUserIDs.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contents != null) hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
