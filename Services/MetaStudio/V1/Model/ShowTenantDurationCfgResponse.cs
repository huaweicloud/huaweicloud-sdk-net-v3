using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTenantDurationCfgResponse : SdkResponse
    {

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 基础版最低时长（秒）
        /// </summary>
        [JsonProperty("basic_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicMin { get; set; }

        /// <summary>
        /// 基础版最高时长（秒）
        /// </summary>
        [JsonProperty("basic_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicMax { get; set; }

        /// <summary>
        /// 建议时长（秒）
        /// </summary>
        [JsonProperty("basic_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicAdviceValue { get; set; }

        /// <summary>
        /// 进阶版最低时长（秒）
        /// </summary>
        [JsonProperty("middle_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? MiddleMin { get; set; }

        /// <summary>
        /// 进阶版最高时长（秒）
        /// </summary>
        [JsonProperty("middle_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? MiddleMax { get; set; }

        /// <summary>
        /// 建议时长（秒）
        /// </summary>
        [JsonProperty("middle_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MiddleAdviceValue { get; set; }

        /// <summary>
        /// 高级版最低时长（秒）
        /// </summary>
        [JsonProperty("advance_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdvanceMin { get; set; }

        /// <summary>
        /// 高级版最高时长（秒）
        /// </summary>
        [JsonProperty("advance_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdvanceMax { get; set; }

        /// <summary>
        /// 建议时长（秒）
        /// </summary>
        [JsonProperty("advance_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdvanceAdviceValue { get; set; }

        /// <summary>
        /// flexus版最低时长（秒）
        /// </summary>
        [JsonProperty("flexus_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlexusMin { get; set; }

        /// <summary>
        /// flexus版最高时长（秒）
        /// </summary>
        [JsonProperty("flexus_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlexusMax { get; set; }

        /// <summary>
        /// flexus建议时长（秒）
        /// </summary>
        [JsonProperty("flexus_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlexusAdviceValue { get; set; }

        /// <summary>
        /// 出门问问最低时长（秒）
        /// </summary>
        [JsonProperty("cmww_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? CmwwMin { get; set; }

        /// <summary>
        /// 出门问问最高时长（秒）
        /// </summary>
        [JsonProperty("cmww_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? CmwwMax { get; set; }

        /// <summary>
        /// 出门问问建议时长（秒）
        /// </summary>
        [JsonProperty("cmww_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? CmwwAdviceValue { get; set; }

        /// <summary>
        /// 逻辑智能最低时长（秒）
        /// </summary>
        [JsonProperty("ljzn_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? LjznMin { get; set; }

        /// <summary>
        /// 逻辑智能最高时长（秒）
        /// </summary>
        [JsonProperty("ljzn_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? LjznMax { get; set; }

        /// <summary>
        /// 逻辑智能建议时长（秒）
        /// </summary>
        [JsonProperty("ljzn_advice_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? LjznAdviceValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantDurationCfgResponse {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  basicMin: ").Append(BasicMin).Append("\n");
            sb.Append("  basicMax: ").Append(BasicMax).Append("\n");
            sb.Append("  basicAdviceValue: ").Append(BasicAdviceValue).Append("\n");
            sb.Append("  middleMin: ").Append(MiddleMin).Append("\n");
            sb.Append("  middleMax: ").Append(MiddleMax).Append("\n");
            sb.Append("  middleAdviceValue: ").Append(MiddleAdviceValue).Append("\n");
            sb.Append("  advanceMin: ").Append(AdvanceMin).Append("\n");
            sb.Append("  advanceMax: ").Append(AdvanceMax).Append("\n");
            sb.Append("  advanceAdviceValue: ").Append(AdvanceAdviceValue).Append("\n");
            sb.Append("  flexusMin: ").Append(FlexusMin).Append("\n");
            sb.Append("  flexusMax: ").Append(FlexusMax).Append("\n");
            sb.Append("  flexusAdviceValue: ").Append(FlexusAdviceValue).Append("\n");
            sb.Append("  cmwwMin: ").Append(CmwwMin).Append("\n");
            sb.Append("  cmwwMax: ").Append(CmwwMax).Append("\n");
            sb.Append("  cmwwAdviceValue: ").Append(CmwwAdviceValue).Append("\n");
            sb.Append("  ljznMin: ").Append(LjznMin).Append("\n");
            sb.Append("  ljznMax: ").Append(LjznMax).Append("\n");
            sb.Append("  ljznAdviceValue: ").Append(LjznAdviceValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantDurationCfgResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantDurationCfgResponse input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.BasicMin != input.BasicMin || (this.BasicMin != null && !this.BasicMin.Equals(input.BasicMin))) return false;
            if (this.BasicMax != input.BasicMax || (this.BasicMax != null && !this.BasicMax.Equals(input.BasicMax))) return false;
            if (this.BasicAdviceValue != input.BasicAdviceValue || (this.BasicAdviceValue != null && !this.BasicAdviceValue.Equals(input.BasicAdviceValue))) return false;
            if (this.MiddleMin != input.MiddleMin || (this.MiddleMin != null && !this.MiddleMin.Equals(input.MiddleMin))) return false;
            if (this.MiddleMax != input.MiddleMax || (this.MiddleMax != null && !this.MiddleMax.Equals(input.MiddleMax))) return false;
            if (this.MiddleAdviceValue != input.MiddleAdviceValue || (this.MiddleAdviceValue != null && !this.MiddleAdviceValue.Equals(input.MiddleAdviceValue))) return false;
            if (this.AdvanceMin != input.AdvanceMin || (this.AdvanceMin != null && !this.AdvanceMin.Equals(input.AdvanceMin))) return false;
            if (this.AdvanceMax != input.AdvanceMax || (this.AdvanceMax != null && !this.AdvanceMax.Equals(input.AdvanceMax))) return false;
            if (this.AdvanceAdviceValue != input.AdvanceAdviceValue || (this.AdvanceAdviceValue != null && !this.AdvanceAdviceValue.Equals(input.AdvanceAdviceValue))) return false;
            if (this.FlexusMin != input.FlexusMin || (this.FlexusMin != null && !this.FlexusMin.Equals(input.FlexusMin))) return false;
            if (this.FlexusMax != input.FlexusMax || (this.FlexusMax != null && !this.FlexusMax.Equals(input.FlexusMax))) return false;
            if (this.FlexusAdviceValue != input.FlexusAdviceValue || (this.FlexusAdviceValue != null && !this.FlexusAdviceValue.Equals(input.FlexusAdviceValue))) return false;
            if (this.CmwwMin != input.CmwwMin || (this.CmwwMin != null && !this.CmwwMin.Equals(input.CmwwMin))) return false;
            if (this.CmwwMax != input.CmwwMax || (this.CmwwMax != null && !this.CmwwMax.Equals(input.CmwwMax))) return false;
            if (this.CmwwAdviceValue != input.CmwwAdviceValue || (this.CmwwAdviceValue != null && !this.CmwwAdviceValue.Equals(input.CmwwAdviceValue))) return false;
            if (this.LjznMin != input.LjznMin || (this.LjznMin != null && !this.LjznMin.Equals(input.LjznMin))) return false;
            if (this.LjznMax != input.LjznMax || (this.LjznMax != null && !this.LjznMax.Equals(input.LjznMax))) return false;
            if (this.LjznAdviceValue != input.LjznAdviceValue || (this.LjznAdviceValue != null && !this.LjznAdviceValue.Equals(input.LjznAdviceValue))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.BasicMin != null) hashCode = hashCode * 59 + this.BasicMin.GetHashCode();
                if (this.BasicMax != null) hashCode = hashCode * 59 + this.BasicMax.GetHashCode();
                if (this.BasicAdviceValue != null) hashCode = hashCode * 59 + this.BasicAdviceValue.GetHashCode();
                if (this.MiddleMin != null) hashCode = hashCode * 59 + this.MiddleMin.GetHashCode();
                if (this.MiddleMax != null) hashCode = hashCode * 59 + this.MiddleMax.GetHashCode();
                if (this.MiddleAdviceValue != null) hashCode = hashCode * 59 + this.MiddleAdviceValue.GetHashCode();
                if (this.AdvanceMin != null) hashCode = hashCode * 59 + this.AdvanceMin.GetHashCode();
                if (this.AdvanceMax != null) hashCode = hashCode * 59 + this.AdvanceMax.GetHashCode();
                if (this.AdvanceAdviceValue != null) hashCode = hashCode * 59 + this.AdvanceAdviceValue.GetHashCode();
                if (this.FlexusMin != null) hashCode = hashCode * 59 + this.FlexusMin.GetHashCode();
                if (this.FlexusMax != null) hashCode = hashCode * 59 + this.FlexusMax.GetHashCode();
                if (this.FlexusAdviceValue != null) hashCode = hashCode * 59 + this.FlexusAdviceValue.GetHashCode();
                if (this.CmwwMin != null) hashCode = hashCode * 59 + this.CmwwMin.GetHashCode();
                if (this.CmwwMax != null) hashCode = hashCode * 59 + this.CmwwMax.GetHashCode();
                if (this.CmwwAdviceValue != null) hashCode = hashCode * 59 + this.CmwwAdviceValue.GetHashCode();
                if (this.LjznMin != null) hashCode = hashCode * 59 + this.LjznMin.GetHashCode();
                if (this.LjznMax != null) hashCode = hashCode * 59 + this.LjznMax.GetHashCode();
                if (this.LjznAdviceValue != null) hashCode = hashCode * 59 + this.LjznAdviceValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
