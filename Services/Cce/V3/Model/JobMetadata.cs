using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobMetadata 
    {

        /// <summary>
        /// 任务的ID。
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 任务的创建时间。
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 任务的更新时间。
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobMetadata {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
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
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
