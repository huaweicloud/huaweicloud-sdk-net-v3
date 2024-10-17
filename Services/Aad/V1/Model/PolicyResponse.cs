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
    /// 策略响应
    /// </summary>
    public class PolicyResponse 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 防护包id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 防护包名
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 所属region的id
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("clean_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CleanThreshold { get; set; }

        /// <summary>
        /// 防护ip数
        /// </summary>
        [JsonProperty("num_protected_ip", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumProtectedIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  cleanThreshold: ").Append(CleanThreshold).Append("\n");
            sb.Append("  numProtectedIp: ").Append(NumProtectedIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CleanThreshold != input.CleanThreshold || (this.CleanThreshold != null && !this.CleanThreshold.Equals(input.CleanThreshold))) return false;
            if (this.NumProtectedIp != input.NumProtectedIp || (this.NumProtectedIp != null && !this.NumProtectedIp.Equals(input.NumProtectedIp))) return false;

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
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CleanThreshold != null) hashCode = hashCode * 59 + this.CleanThreshold.GetHashCode();
                if (this.NumProtectedIp != null) hashCode = hashCode * 59 + this.NumProtectedIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
