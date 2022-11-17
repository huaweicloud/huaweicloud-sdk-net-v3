using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.v1.Model
{
    /// <summary>
    /// 修改预定义标签
    /// </summary>
    public class ModifyPrefineTag 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("new_tag", NullValueHandling = NullValueHandling.Ignore)]
        public PredefineTagRequest NewTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("old_tag", NullValueHandling = NullValueHandling.Ignore)]
        public PredefineTagRequest OldTag { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPrefineTag {\n");
            sb.Append("  newTag: ").Append(NewTag).Append("\n");
            sb.Append("  oldTag: ").Append(OldTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyPrefineTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPrefineTag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewTag == input.NewTag ||
                    (this.NewTag != null &&
                    this.NewTag.Equals(input.NewTag))
                ) && 
                (
                    this.OldTag == input.OldTag ||
                    (this.OldTag != null &&
                    this.OldTag.Equals(input.OldTag))
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
                if (this.NewTag != null)
                    hashCode = hashCode * 59 + this.NewTag.GetHashCode();
                if (this.OldTag != null)
                    hashCode = hashCode * 59 + this.OldTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
