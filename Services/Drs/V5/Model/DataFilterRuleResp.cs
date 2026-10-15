using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据过滤规则响应体
    /// </summary>
    public class DataFilterRuleResp 
    {

        /// <summary>
        /// 数据过滤规则批次ID，标识同一批次内的多个过滤对象属于同一个规则配置。
        /// </summary>
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BatchId { get; set; }

        /// <summary>
        /// 过滤对象信息列表，列出此规则下所有需进行数据过滤的具体数据库对象
        /// </summary>
        [JsonProperty("filter_object_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataFilterObjectResp> FilterObjectList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter_rules_resp", NullValueHandling = NullValueHandling.Ignore)]
        public GeneralDataFilterResp FilterRulesResp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advanced_setting_resp", NullValueHandling = NullValueHandling.Ignore)]
        public DataFilteringAdvancedSetting AdvancedSettingResp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFilterRuleResp {\n");
            sb.Append("  batchId: ").Append(BatchId).Append("\n");
            sb.Append("  filterObjectList: ").Append(FilterObjectList).Append("\n");
            sb.Append("  filterRulesResp: ").Append(FilterRulesResp).Append("\n");
            sb.Append("  advancedSettingResp: ").Append(AdvancedSettingResp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataFilterRuleResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataFilterRuleResp input)
        {
            if (input == null) return false;
            if (this.BatchId != input.BatchId || (this.BatchId != null && !this.BatchId.Equals(input.BatchId))) return false;
            if (this.FilterObjectList != input.FilterObjectList || (this.FilterObjectList != null && input.FilterObjectList != null && !this.FilterObjectList.SequenceEqual(input.FilterObjectList))) return false;
            if (this.FilterRulesResp != input.FilterRulesResp || (this.FilterRulesResp != null && !this.FilterRulesResp.Equals(input.FilterRulesResp))) return false;
            if (this.AdvancedSettingResp != input.AdvancedSettingResp || (this.AdvancedSettingResp != null && !this.AdvancedSettingResp.Equals(input.AdvancedSettingResp))) return false;

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
                if (this.BatchId != null) hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.FilterObjectList != null) hashCode = hashCode * 59 + this.FilterObjectList.GetHashCode();
                if (this.FilterRulesResp != null) hashCode = hashCode * 59 + this.FilterRulesResp.GetHashCode();
                if (this.AdvancedSettingResp != null) hashCode = hashCode * 59 + this.AdvancedSettingResp.GetHashCode();
                return hashCode;
            }
        }
    }
}
