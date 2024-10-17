using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlarmTags 
    {

        /// <summary>
        /// 自动标签。
        /// </summary>
        [JsonProperty("auto_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AutoTags { get; set; }

        /// <summary>
        /// 自定义标签。
        /// </summary>
        [JsonProperty("custom_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomTags { get; set; }

        /// <summary>
        /// 告警标注。
        /// </summary>
        [JsonProperty("custom_annotations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomAnnotations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTags {\n");
            sb.Append("  autoTags: ").Append(AutoTags).Append("\n");
            sb.Append("  customTags: ").Append(CustomTags).Append("\n");
            sb.Append("  customAnnotations: ").Append(CustomAnnotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmTags);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmTags input)
        {
            if (input == null) return false;
            if (this.AutoTags != input.AutoTags || (this.AutoTags != null && input.AutoTags != null && !this.AutoTags.SequenceEqual(input.AutoTags))) return false;
            if (this.CustomTags != input.CustomTags || (this.CustomTags != null && input.CustomTags != null && !this.CustomTags.SequenceEqual(input.CustomTags))) return false;
            if (this.CustomAnnotations != input.CustomAnnotations || (this.CustomAnnotations != null && input.CustomAnnotations != null && !this.CustomAnnotations.SequenceEqual(input.CustomAnnotations))) return false;

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
                if (this.AutoTags != null) hashCode = hashCode * 59 + this.AutoTags.GetHashCode();
                if (this.CustomTags != null) hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomAnnotations != null) hashCode = hashCode * 59 + this.CustomAnnotations.GetHashCode();
                return hashCode;
            }
        }
    }
}
