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
    public class AccessCodeModel 
    {

        /// <summary>
        /// access_code。
        /// </summary>
        [JsonProperty("access_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessCode { get; set; }

        /// <summary>
        /// access_code_id。
        /// </summary>
        [JsonProperty("access_code_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessCodeId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessCodeModel {\n");
            sb.Append("  accessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  accessCodeId: ").Append(AccessCodeId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessCodeModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessCodeModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
                ) && 
                (
                    this.AccessCodeId == input.AccessCodeId ||
                    (this.AccessCodeId != null &&
                    this.AccessCodeId.Equals(input.AccessCodeId))
                ) && 
                (
                    this.CreateAt == input.CreateAt ||
                    (this.CreateAt != null &&
                    this.CreateAt.Equals(input.CreateAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
                if (this.AccessCodeId != null)
                    hashCode = hashCode * 59 + this.AccessCodeId.GetHashCode();
                if (this.CreateAt != null)
                    hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
