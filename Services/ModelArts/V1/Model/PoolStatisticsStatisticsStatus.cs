using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数描述**： 不同状态下的资源池统计信息。
    /// </summary>
    public class PoolStatisticsStatisticsStatus 
    {

        /// <summary>
        /// **参数描述**： 正在创建中的资源池统计信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("creating", NullValueHandling = NullValueHandling.Ignore)]
        public int? Creating { get; set; }

        /// <summary>
        /// **参数描述**： 创建成功的资源池数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public int? Created { get; set; }

        /// <summary>
        /// **参数描述**： 最近三天内创建失败的资源池数量，最大值为500。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }

        /// <summary>
        /// **参数描述**： 等待中的资源池数量，通常是未支付的包周期资源池。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("pending", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pending { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatisticsStatisticsStatus {\n");
            sb.Append("  creating: ").Append(Creating).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  pending: ").Append(Pending).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatisticsStatisticsStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatisticsStatisticsStatus input)
        {
            if (input == null) return false;
            if (this.Creating != input.Creating || (this.Creating != null && !this.Creating.Equals(input.Creating))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && !this.Failed.Equals(input.Failed))) return false;
            if (this.Pending != input.Pending || (this.Pending != null && !this.Pending.Equals(input.Pending))) return false;

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
                if (this.Creating != null) hashCode = hashCode * 59 + this.Creating.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Pending != null) hashCode = hashCode * 59 + this.Pending.GetHashCode();
                return hashCode;
            }
        }
    }
}
