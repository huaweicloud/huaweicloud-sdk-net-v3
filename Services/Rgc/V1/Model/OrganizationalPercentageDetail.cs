using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 创建账号、纳管注册OU、纳管账号状态信息。
    /// </summary>
    public class OrganizationalPercentageDetail 
    {

        /// <summary>
        /// 进度名称。
        /// </summary>
        [JsonProperty("percentage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PercentageName { get; set; }

        /// <summary>
        /// 创建账号、注册OU、纳管账号的进度完成状态。
        /// </summary>
        [JsonProperty("percentage_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PercentageStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationalPercentageDetail {\n");
            sb.Append("  percentageName: ").Append(PercentageName).Append("\n");
            sb.Append("  percentageStatus: ").Append(PercentageStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationalPercentageDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationalPercentageDetail input)
        {
            if (input == null) return false;
            if (this.PercentageName != input.PercentageName || (this.PercentageName != null && !this.PercentageName.Equals(input.PercentageName))) return false;
            if (this.PercentageStatus != input.PercentageStatus || (this.PercentageStatus != null && !this.PercentageStatus.Equals(input.PercentageStatus))) return false;

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
                if (this.PercentageName != null) hashCode = hashCode * 59 + this.PercentageName.GetHashCode();
                if (this.PercentageStatus != null) hashCode = hashCode * 59 + this.PercentageStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
