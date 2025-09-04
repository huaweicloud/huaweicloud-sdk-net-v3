using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceResourceInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic_info", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceBasicInfo BasicInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceResourceInfo {\n");
            sb.Append("  basicInfo: ").Append(BasicInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceResourceInfo input)
        {
            if (input == null) return false;
            if (this.BasicInfo != input.BasicInfo || (this.BasicInfo != null && !this.BasicInfo.Equals(input.BasicInfo))) return false;

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
                if (this.BasicInfo != null) hashCode = hashCode * 59 + this.BasicInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
