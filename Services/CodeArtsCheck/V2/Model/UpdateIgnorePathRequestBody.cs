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
    public class UpdateIgnorePathRequestBody 
    {

        /// <summary>
        /// 屏蔽目录的节点信息列表
        /// </summary>
        [JsonProperty("ignore_path_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<IgnorePathSettingItem> IgnorePathSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIgnorePathRequestBody {\n");
            sb.Append("  ignorePathSettings: ").Append(IgnorePathSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateIgnorePathRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateIgnorePathRequestBody input)
        {
            if (input == null) return false;
            if (this.IgnorePathSettings != input.IgnorePathSettings || (this.IgnorePathSettings != null && input.IgnorePathSettings != null && !this.IgnorePathSettings.SequenceEqual(input.IgnorePathSettings))) return false;

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
                if (this.IgnorePathSettings != null) hashCode = hashCode * 59 + this.IgnorePathSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
