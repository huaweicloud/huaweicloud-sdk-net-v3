using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 包周期资源对象。
    /// </summary>
    public class Resource 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public AddVolumes AddVolumes { get; set; }

        /// <summary>
        /// 支付后跳转的地址。
        /// </summary>
        [JsonProperty("cloud_service_console_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceConsoleUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_services", NullValueHandling = NullValueHandling.Ignore)]
        public CreateServices CreateServices { get; set; }

        /// <summary>
        /// 订购关系当前是否是自动续费：0 否 1 是。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 订购周期数取值大于0。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 包周期订单订购周期类型：2：月；3：年；4：包小时（仅限带宽加油包购买场景使用）5：绝对时间；（追加附属资源场景使用，比如主机上追加云硬盘）6：一次性（chargingMode&#x3D;1 一次性计费场景使用），必填。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 订购数量。
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  addVolumes: ").Append(AddVolumes).Append("\n");
            sb.Append("  cloudServiceConsoleUrl: ").Append(CloudServiceConsoleUrl).Append("\n");
            sb.Append("  createServices: ").Append(CreateServices).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Resource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Resource input)
        {
            if (input == null) return false;
            if (this.AddVolumes != input.AddVolumes || (this.AddVolumes != null && !this.AddVolumes.Equals(input.AddVolumes))) return false;
            if (this.CloudServiceConsoleUrl != input.CloudServiceConsoleUrl || (this.CloudServiceConsoleUrl != null && !this.CloudServiceConsoleUrl.Equals(input.CloudServiceConsoleUrl))) return false;
            if (this.CreateServices != input.CreateServices || (this.CreateServices != null && !this.CreateServices.Equals(input.CreateServices))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;

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
                if (this.AddVolumes != null) hashCode = hashCode * 59 + this.AddVolumes.GetHashCode();
                if (this.CloudServiceConsoleUrl != null) hashCode = hashCode * 59 + this.CloudServiceConsoleUrl.GetHashCode();
                if (this.CreateServices != null) hashCode = hashCode * 59 + this.CreateServices.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
