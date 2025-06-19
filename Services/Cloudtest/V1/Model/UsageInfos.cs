using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 资源已用容量对象
    /// </summary>
    public class UsageInfos 
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源总量
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 已消耗用量
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public string Used { get; set; }

        /// <summary>
        /// 资源已用容量百分比,例如80% 值为80
        /// </summary>
        [JsonProperty("used_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedPercent { get; set; }

        /// <summary>
        /// 版本超限信息
        /// </summary>
        [JsonProperty("usage_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<UsageInfos> UsageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageInfos {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  usedPercent: ").Append(UsedPercent).Append("\n");
            sb.Append("  usageInfo: ").Append(UsageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsageInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UsageInfos input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.UsedPercent != input.UsedPercent || (this.UsedPercent != null && !this.UsedPercent.Equals(input.UsedPercent))) return false;
            if (this.UsageInfo != input.UsageInfo || (this.UsageInfo != null && input.UsageInfo != null && !this.UsageInfo.SequenceEqual(input.UsageInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.UsedPercent != null) hashCode = hashCode * 59 + this.UsedPercent.GetHashCode();
                if (this.UsageInfo != null) hashCode = hashCode * 59 + this.UsageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
