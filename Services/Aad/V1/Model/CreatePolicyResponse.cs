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
    public class CreatePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 防护包id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("clean_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CleanThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePolicyResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cleanThreshold: ").Append(CleanThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CleanThreshold == input.CleanThreshold ||
                    (this.CleanThreshold != null &&
                    this.CleanThreshold.Equals(input.CleanThreshold))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PackageId != null)
                    hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CleanThreshold != null)
                    hashCode = hashCode * 59 + this.CleanThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
