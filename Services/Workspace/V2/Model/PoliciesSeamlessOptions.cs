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
    /// 通用音视频设置项。
    /// </summary>
    public class PoliciesSeamlessOptions 
    {

        /// <summary>
        /// 软件路径。
        /// </summary>
        [JsonProperty("seamless_apply_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SeamlessApplyPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesSeamlessOptions {\n");
            sb.Append("  seamlessApplyPath: ").Append(SeamlessApplyPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesSeamlessOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesSeamlessOptions input)
        {
            if (input == null) return false;
            if (this.SeamlessApplyPath != input.SeamlessApplyPath || (this.SeamlessApplyPath != null && !this.SeamlessApplyPath.Equals(input.SeamlessApplyPath))) return false;

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
                if (this.SeamlessApplyPath != null) hashCode = hashCode * 59 + this.SeamlessApplyPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
