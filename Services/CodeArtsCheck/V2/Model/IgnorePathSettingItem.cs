using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IgnorePathSettingItem 
    {

        /// <summary>
        /// 目录或文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 屏蔽状态，包括unchecked(不屏蔽)、all(全屏蔽)、half(半屏蔽)
        /// </summary>
        [JsonProperty("checkbox_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckboxStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IgnorePathSettingItem {\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  checkboxStatus: ").Append(CheckboxStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IgnorePathSettingItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IgnorePathSettingItem input)
        {
            if (input == null) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.CheckboxStatus != input.CheckboxStatus || (this.CheckboxStatus != null && !this.CheckboxStatus.Equals(input.CheckboxStatus))) return false;

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
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.CheckboxStatus != null) hashCode = hashCode * 59 + this.CheckboxStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
