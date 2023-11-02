using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 操作详情
    /// </summary>
    public class Operations 
    {

        /// <summary>
        /// 操作信息
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 是否支持该操作
        /// </summary>
        [JsonProperty("is_support", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupport { get; set; }

        /// <summary>
        /// 不支持该操作的原因ID，仅在is_support为false时返回
        /// </summary>
        [JsonProperty("cause_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CauseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operations {\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  isSupport: ").Append(IsSupport).Append("\n");
            sb.Append("  causeId: ").Append(CauseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Operations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Operations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.IsSupport == input.IsSupport ||
                    (this.IsSupport != null &&
                    this.IsSupport.Equals(input.IsSupport))
                ) && 
                (
                    this.CauseId == input.CauseId ||
                    (this.CauseId != null &&
                    this.CauseId.Equals(input.CauseId))
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
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.IsSupport != null)
                    hashCode = hashCode * 59 + this.IsSupport.GetHashCode();
                if (this.CauseId != null)
                    hashCode = hashCode * 59 + this.CauseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
