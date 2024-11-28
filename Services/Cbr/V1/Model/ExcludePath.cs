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
    public class ExcludePath 
    {

        /// <summary>
        /// 备份目录
        /// </summary>
        [JsonProperty("path_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PathName { get; set; }

        /// <summary>
        /// 排除目录列表
        /// </summary>
        [JsonProperty("exclude_path_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludePathName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExcludePath {\n");
            sb.Append("  pathName: ").Append(PathName).Append("\n");
            sb.Append("  excludePathName: ").Append(ExcludePathName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExcludePath);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExcludePath input)
        {
            if (input == null) return false;
            if (this.PathName != input.PathName || (this.PathName != null && !this.PathName.Equals(input.PathName))) return false;
            if (this.ExcludePathName != input.ExcludePathName || (this.ExcludePathName != null && input.ExcludePathName != null && !this.ExcludePathName.SequenceEqual(input.ExcludePathName))) return false;

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
                if (this.PathName != null) hashCode = hashCode * 59 + this.PathName.GetHashCode();
                if (this.ExcludePathName != null) hashCode = hashCode * 59 + this.ExcludePathName.GetHashCode();
                return hashCode;
            }
        }
    }
}
