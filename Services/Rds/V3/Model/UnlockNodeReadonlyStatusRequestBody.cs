using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 解除只读请求体
    /// </summary>
    public class UnlockNodeReadonlyStatusRequestBody 
    {

        /// <summary>
        /// Ha保持不再设置节点只读状态的时间，单位为分钟。
        /// </summary>
        [JsonProperty("status_preservation_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusPreservationTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnlockNodeReadonlyStatusRequestBody {\n");
            sb.Append("  statusPreservationTime: ").Append(StatusPreservationTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnlockNodeReadonlyStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnlockNodeReadonlyStatusRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusPreservationTime == input.StatusPreservationTime ||
                    (this.StatusPreservationTime != null &&
                    this.StatusPreservationTime.Equals(input.StatusPreservationTime))
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
                if (this.StatusPreservationTime != null)
                    hashCode = hashCode * 59 + this.StatusPreservationTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
