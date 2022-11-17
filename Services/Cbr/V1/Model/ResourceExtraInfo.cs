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
    public class ResourceExtraInfo 
    {

        /// <summary>
        /// 需要排除备份的卷id。仅在多系统盘备份特性中有效，排除不需要备份的磁盘。当虚拟机新绑定磁盘时，也能继续排除之前设置不用备份的卷。
        /// </summary>
        [JsonProperty("exclude_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludeVolumes { get; set; }

        /// <summary>
        /// 指定需要备份的卷,若有指定值，则每次备份都只备份指定的卷，如虚拟机绑定存储库之后新绑定的卷不会备份；若为空默认为资源全部卷；仅虚拟机磁盘级备份特性中有效。
        /// </summary>
        [JsonProperty("include_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceExtraInfoIncludeVolumes> IncludeVolumes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceExtraInfo {\n");
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
            return this.Equals(input as ResourceExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeVolumes == input.ExcludeVolumes ||
                    this.ExcludeVolumes != null &&
                    input.ExcludeVolumes != null &&
                    this.ExcludeVolumes.SequenceEqual(input.ExcludeVolumes)
                ) && 
                (
                    this.IncludeVolumes == input.IncludeVolumes ||
                    this.IncludeVolumes != null &&
                    input.IncludeVolumes != null &&
                    this.IncludeVolumes.SequenceEqual(input.IncludeVolumes)
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
                if (this.ExcludeVolumes != null)
                    hashCode = hashCode * 59 + this.ExcludeVolumes.GetHashCode();
                if (this.IncludeVolumes != null)
                    hashCode = hashCode * 59 + this.IncludeVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
