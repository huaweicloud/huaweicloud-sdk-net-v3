using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 分配情况统计。
    /// </summary>
    public class AttachStatistics 
    {

        /// <summary>
        /// 已分配个数。
        /// </summary>
        [JsonProperty("attached_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachedNum { get; set; }

        /// <summary>
        /// 未分配个数。
        /// </summary>
        [JsonProperty("unattached_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnattachedNum { get; set; }

        /// <summary>
        /// 分配中个数。
        /// </summary>
        [JsonProperty("attaching_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachingNum { get; set; }

        /// <summary>
        /// 分配失败的个数。
        /// </summary>
        [JsonProperty("attach_error_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachErrorNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachStatistics {\n");
            sb.Append("  attachedNum: ").Append(AttachedNum).Append("\n");
            sb.Append("  unattachedNum: ").Append(UnattachedNum).Append("\n");
            sb.Append("  attachingNum: ").Append(AttachingNum).Append("\n");
            sb.Append("  attachErrorNum: ").Append(AttachErrorNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachStatistics input)
        {
            if (input == null) return false;
            if (this.AttachedNum != input.AttachedNum || (this.AttachedNum != null && !this.AttachedNum.Equals(input.AttachedNum))) return false;
            if (this.UnattachedNum != input.UnattachedNum || (this.UnattachedNum != null && !this.UnattachedNum.Equals(input.UnattachedNum))) return false;
            if (this.AttachingNum != input.AttachingNum || (this.AttachingNum != null && !this.AttachingNum.Equals(input.AttachingNum))) return false;
            if (this.AttachErrorNum != input.AttachErrorNum || (this.AttachErrorNum != null && !this.AttachErrorNum.Equals(input.AttachErrorNum))) return false;

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
                if (this.AttachedNum != null) hashCode = hashCode * 59 + this.AttachedNum.GetHashCode();
                if (this.UnattachedNum != null) hashCode = hashCode * 59 + this.UnattachedNum.GetHashCode();
                if (this.AttachingNum != null) hashCode = hashCode * 59 + this.AttachingNum.GetHashCode();
                if (this.AttachErrorNum != null) hashCode = hashCode * 59 + this.AttachErrorNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
