using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NoSqlEpsQuotaUsed 
    {

        /// <summary>
        /// 已使用实例配额。
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public int? Instance { get; set; }

        /// <summary>
        /// 已使用vcpus配额。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 已使用ram配额。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoSqlEpsQuotaUsed {\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NoSqlEpsQuotaUsed);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NoSqlEpsQuotaUsed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
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
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                return hashCode;
            }
        }
    }
}
