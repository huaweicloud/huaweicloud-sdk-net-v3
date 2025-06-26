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
    /// 配置关联成员。
    /// </summary>
    public class Attachment 
    {

        /// <summary>
        /// 目标。
        /// </summary>
        [JsonProperty("attach", NullValueHandling = NullValueHandling.Ignore)]
        public string Attach { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attach_type", NullValueHandling = NullValueHandling.Ignore)]
        public AttachType AttachType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  attach: ").Append(Attach).Append("\n");
            sb.Append("  attachType: ").Append(AttachType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Attachment input)
        {
            if (input == null) return false;
            if (this.Attach != input.Attach || (this.Attach != null && !this.Attach.Equals(input.Attach))) return false;
            if (this.AttachType != input.AttachType) return false;

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
                if (this.Attach != null) hashCode = hashCode * 59 + this.Attach.GetHashCode();
                hashCode = hashCode * 59 + this.AttachType.GetHashCode();
                return hashCode;
            }
        }
    }
}
