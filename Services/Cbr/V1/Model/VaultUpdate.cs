using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VaultUpdate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingUpdate Billing { get; set; }

        /// <summary>
        /// 存储库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否支持自动挂载
        /// </summary>
        [JsonProperty("auto_bind", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoBind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bind_rules", NullValueHandling = NullValueHandling.Ignore)]
        public VaultBindRules BindRules { get; set; }

        /// <summary>
        /// 是否自动扩容。按需存储库支持自动扩容，包周期存储库不支持扩容。
        /// </summary>
        [JsonProperty("auto_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExpand { get; set; }

        /// <summary>
        /// 发送smn通知开关
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 存储库容量阈值，存储库已用容量和总容量的百分比超过该值，若smn_notify为开，将发送相关通知。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultUpdate {\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoBind: ").Append(AutoBind).Append("\n");
            sb.Append("  bindRules: ").Append(BindRules).Append("\n");
            sb.Append("  autoExpand: ").Append(AutoExpand).Append("\n");
            sb.Append("  smnNotify: ").Append(SmnNotify).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AutoBind == input.AutoBind ||
                    (this.AutoBind != null &&
                    this.AutoBind.Equals(input.AutoBind))
                ) && 
                (
                    this.BindRules == input.BindRules ||
                    (this.BindRules != null &&
                    this.BindRules.Equals(input.BindRules))
                ) && 
                (
                    this.AutoExpand == input.AutoExpand ||
                    (this.AutoExpand != null &&
                    this.AutoExpand.Equals(input.AutoExpand))
                ) && 
                (
                    this.SmnNotify == input.SmnNotify ||
                    (this.SmnNotify != null &&
                    this.SmnNotify.Equals(input.SmnNotify))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
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
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AutoBind != null)
                    hashCode = hashCode * 59 + this.AutoBind.GetHashCode();
                if (this.BindRules != null)
                    hashCode = hashCode * 59 + this.BindRules.GetHashCode();
                if (this.AutoExpand != null)
                    hashCode = hashCode * 59 + this.AutoExpand.GetHashCode();
                if (this.SmnNotify != null)
                    hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
