using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FrequencyControlRule 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 判断是否是智能cc生成的规则
        /// </summary>
        [JsonProperty("producer", NullValueHandling = NullValueHandling.Ignore)]
        public int? Producer { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则应用的url
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 限速频率，单位为次，范围为1~2147483647
        /// </summary>
        [JsonProperty("limit_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitNum { get; set; }

        /// <summary>
        /// 限速周期，单位为秒，范围1~3600
        /// </summary>
        [JsonProperty("limit_period", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitPeriod { get; set; }

        /// <summary>
        /// 阻断时间，单位为秒，范围为0~65535
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTime { get; set; }

        /// <summary>
        /// 限速模式：ip、cookie、header、other、policy、domain、url。 源限速：ip：IP限速，根据IP区分单个Web访问者。cookie：用户限速，根据Cookie键值区分单个Web访问者。header：用户限速，根据Header区分单个Web访问者。other：根据Referer（自定义请求访问的来源）字段区分单个Web访问者。-目的限速：policy: 策略限速、domain: 域名限速、url: url限速
        /// </summary>
        [JsonProperty("tag_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TagType { get; set; }

        /// <summary>
        /// 用户标识，当限速模式为用户限速(cookie或header)时
        /// </summary>
        [JsonProperty("tag_index", NullValueHandling = NullValueHandling.Ignore)]
        public string TagIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag_condition", NullValueHandling = NullValueHandling.Ignore)]
        public TagCondition TagCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionInfo Action { get; set; }

        /// <summary>
        /// cc规则防护模式，0：标准(老版本)，只支持对域名的防护路径做限制。1：高级(新版本)，支持对路径、IP、Cookie、Header、Params字段做限制。修改CC规则时必须传mode
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// cc规则防护规则限速条件
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Condition> Conditions { get; set; }

        /// <summary>
        /// 放行频率，单位为次，范围为0~2147483647
        /// </summary>
        [JsonProperty("unlock_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnlockNum { get; set; }

        /// <summary>
        /// 域名聚合统计
        /// </summary>
        [JsonProperty("domain_aggregation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomainAggregation { get; set; }

        /// <summary>
        /// 全局计数
        /// </summary>
        [JsonProperty("region_aggregation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegionAggregation { get; set; }

        /// <summary>
        /// 锁定验证时间
        /// </summary>
        [JsonProperty("captcha_lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaptchaLockTime { get; set; }

        /// <summary>
        /// 是否灰度生效
        /// </summary>
        [JsonProperty("grayscale_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GrayscaleTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrequencyControlRule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  producer: ").Append(Producer).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  limitNum: ").Append(LimitNum).Append("\n");
            sb.Append("  limitPeriod: ").Append(LimitPeriod).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  tagType: ").Append(TagType).Append("\n");
            sb.Append("  tagIndex: ").Append(TagIndex).Append("\n");
            sb.Append("  tagCondition: ").Append(TagCondition).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  unlockNum: ").Append(UnlockNum).Append("\n");
            sb.Append("  domainAggregation: ").Append(DomainAggregation).Append("\n");
            sb.Append("  regionAggregation: ").Append(RegionAggregation).Append("\n");
            sb.Append("  captchaLockTime: ").Append(CaptchaLockTime).Append("\n");
            sb.Append("  grayscaleTime: ").Append(GrayscaleTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrequencyControlRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrequencyControlRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Producer == input.Producer ||
                    (this.Producer != null &&
                    this.Producer.Equals(input.Producer))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.LimitNum == input.LimitNum ||
                    (this.LimitNum != null &&
                    this.LimitNum.Equals(input.LimitNum))
                ) && 
                (
                    this.LimitPeriod == input.LimitPeriod ||
                    (this.LimitPeriod != null &&
                    this.LimitPeriod.Equals(input.LimitPeriod))
                ) && 
                (
                    this.LockTime == input.LockTime ||
                    (this.LockTime != null &&
                    this.LockTime.Equals(input.LockTime))
                ) && 
                (
                    this.TagType == input.TagType ||
                    (this.TagType != null &&
                    this.TagType.Equals(input.TagType))
                ) && 
                (
                    this.TagIndex == input.TagIndex ||
                    (this.TagIndex != null &&
                    this.TagIndex.Equals(input.TagIndex))
                ) && 
                (
                    this.TagCondition == input.TagCondition ||
                    (this.TagCondition != null &&
                    this.TagCondition.Equals(input.TagCondition))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.UnlockNum == input.UnlockNum ||
                    (this.UnlockNum != null &&
                    this.UnlockNum.Equals(input.UnlockNum))
                ) && 
                (
                    this.DomainAggregation == input.DomainAggregation ||
                    (this.DomainAggregation != null &&
                    this.DomainAggregation.Equals(input.DomainAggregation))
                ) && 
                (
                    this.RegionAggregation == input.RegionAggregation ||
                    (this.RegionAggregation != null &&
                    this.RegionAggregation.Equals(input.RegionAggregation))
                ) && 
                (
                    this.CaptchaLockTime == input.CaptchaLockTime ||
                    (this.CaptchaLockTime != null &&
                    this.CaptchaLockTime.Equals(input.CaptchaLockTime))
                ) && 
                (
                    this.GrayscaleTime == input.GrayscaleTime ||
                    (this.GrayscaleTime != null &&
                    this.GrayscaleTime.Equals(input.GrayscaleTime))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Producer != null)
                    hashCode = hashCode * 59 + this.Producer.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.LimitNum != null)
                    hashCode = hashCode * 59 + this.LimitNum.GetHashCode();
                if (this.LimitPeriod != null)
                    hashCode = hashCode * 59 + this.LimitPeriod.GetHashCode();
                if (this.LockTime != null)
                    hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.TagType != null)
                    hashCode = hashCode * 59 + this.TagType.GetHashCode();
                if (this.TagIndex != null)
                    hashCode = hashCode * 59 + this.TagIndex.GetHashCode();
                if (this.TagCondition != null)
                    hashCode = hashCode * 59 + this.TagCondition.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.UnlockNum != null)
                    hashCode = hashCode * 59 + this.UnlockNum.GetHashCode();
                if (this.DomainAggregation != null)
                    hashCode = hashCode * 59 + this.DomainAggregation.GetHashCode();
                if (this.RegionAggregation != null)
                    hashCode = hashCode * 59 + this.RegionAggregation.GetHashCode();
                if (this.CaptchaLockTime != null)
                    hashCode = hashCode * 59 + this.CaptchaLockTime.GetHashCode();
                if (this.GrayscaleTime != null)
                    hashCode = hashCode * 59 + this.GrayscaleTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
