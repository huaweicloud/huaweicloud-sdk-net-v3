using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 防护包id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("clean_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CleanThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pop_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PopPolicy PopPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPolicyResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cleanThreshold: ").Append(CleanThreshold).Append("\n");
            sb.Append("  popPolicy: ").Append(PopPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPolicyResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CleanThreshold != input.CleanThreshold || (this.CleanThreshold != null && !this.CleanThreshold.Equals(input.CleanThreshold))) return false;
            if (this.PopPolicy != input.PopPolicy || (this.PopPolicy != null && !this.PopPolicy.Equals(input.PopPolicy))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CleanThreshold != null) hashCode = hashCode * 59 + this.CleanThreshold.GetHashCode();
                if (this.PopPolicy != null) hashCode = hashCode * 59 + this.PopPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
