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
    /// 
    /// </summary>
    public class OpResourceExtraInfoResp 
    {

        /// <summary>
        /// **参数解释：** 需要排除备份的卷ID列表，列表元素为String类型的UUID。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("exclude_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludeVolumes { get; set; }

        /// <summary>
        /// **参数解释：** 指定需要备份的卷，如果有指定值，则每次备份都只备份指定的卷，如虚拟机绑定存储库之后新绑定的卷不会备份；如果为空默认为资源全部卷；仅虚拟机磁盘级备份特性中有效
        /// </summary>
        [JsonProperty("include_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceExtraInfoIncludeVolumesResp> IncludeVolumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpResourceExtraInfoResp {\n");
            sb.Append("  excludeVolumes: ").Append(ExcludeVolumes).Append("\n");
            sb.Append("  includeVolumes: ").Append(IncludeVolumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpResourceExtraInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpResourceExtraInfoResp input)
        {
            if (input == null) return false;
            if (this.ExcludeVolumes != input.ExcludeVolumes || (this.ExcludeVolumes != null && input.ExcludeVolumes != null && !this.ExcludeVolumes.SequenceEqual(input.ExcludeVolumes))) return false;
            if (this.IncludeVolumes != input.IncludeVolumes || (this.IncludeVolumes != null && input.IncludeVolumes != null && !this.IncludeVolumes.SequenceEqual(input.IncludeVolumes))) return false;

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
                if (this.ExcludeVolumes != null) hashCode = hashCode * 59 + this.ExcludeVolumes.GetHashCode();
                if (this.IncludeVolumes != null) hashCode = hashCode * 59 + this.IncludeVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
