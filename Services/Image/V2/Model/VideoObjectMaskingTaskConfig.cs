using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoObjectMaskingTaskConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public VideoObjectMaskingTaskConfigCommon Common { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoObjectMaskingTaskConfig {\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoObjectMaskingTaskConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoObjectMaskingTaskConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Common == input.Common ||
                    (this.Common != null &&
                    this.Common.Equals(input.Common))
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
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
