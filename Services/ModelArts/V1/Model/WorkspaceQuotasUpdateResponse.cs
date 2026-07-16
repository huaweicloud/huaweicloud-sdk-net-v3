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
    /// quotas属性列表。
    /// </summary>
    public class WorkspaceQuotasUpdateResponse 
    {

        /// <summary>
        /// 配额允许设置的最大值。
        /// </summary>
        [JsonProperty("max_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxQuota { get; set; }

        /// <summary>
        /// 最后修改时间，UTC。如用户未修改过该资源配额,则该值默认为该工作空间的创建时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 资源的唯一标识。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// 当前配额值。配额值为-1代表不限制配额。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// 配额允许设置的最小值。
        /// </summary>
        [JsonProperty("min_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinQuota { get; set; }

        /// <summary>
        /// 配额名称[（中文）](tag:hc,hk)。
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 数量单位[（中文）](tag:hc,hk)。
        /// </summary>
        [JsonProperty("unit_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitCn { get; set; }

        /// <summary>
        /// 工作空间ID，系统生成的32位UUID，不带橫线。默认的工作空间id为&#39;0&#39;。
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 数量单位(英文)。
        /// </summary>
        [JsonProperty("unit_en", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitEn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceQuotasUpdateResponse {\n");
            sb.Append("  maxQuota: ").Append(MaxQuota).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  minQuota: ").Append(MinQuota).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  unitCn: ").Append(UnitCn).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  unitEn: ").Append(UnitEn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkspaceQuotasUpdateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkspaceQuotasUpdateResponse input)
        {
            if (input == null) return false;
            if (this.MaxQuota != input.MaxQuota || (this.MaxQuota != null && !this.MaxQuota.Equals(input.MaxQuota))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.MinQuota != input.MinQuota || (this.MinQuota != null && !this.MinQuota.Equals(input.MinQuota))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.UnitCn != input.UnitCn || (this.UnitCn != null && !this.UnitCn.Equals(input.UnitCn))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.UnitEn != input.UnitEn || (this.UnitEn != null && !this.UnitEn.Equals(input.UnitEn))) return false;

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
                if (this.MaxQuota != null) hashCode = hashCode * 59 + this.MaxQuota.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.MinQuota != null) hashCode = hashCode * 59 + this.MinQuota.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.UnitCn != null) hashCode = hashCode * 59 + this.UnitCn.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.UnitEn != null) hashCode = hashCode * 59 + this.UnitEn.GetHashCode();
                return hashCode;
            }
        }
    }
}
