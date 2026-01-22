using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 查询规则列表返回值数据
    /// </summary>
    public class RuleAclListResponseDTOData 
    {

        /// <summary>
        /// **参数解释**： 偏移量：指定返回记录的开始位置 **取值范围**： 大于或等于0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 每页显示个数 **取值范围**： 1-1024
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 查询规则列表总条数 **取值范围**： 大于0
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID，type可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得  **取值范围**：  32位UUID
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： 顶部规则数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("up_rules_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpRulesCount { get; set; }

        /// <summary>
        /// **参数解释**： 查询规则列表记录
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleAclListResponseDTODataRecords> Records { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAclListResponseDTOData {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  upRulesCount: ").Append(UpRulesCount).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAclListResponseDTOData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAclListResponseDTOData input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.UpRulesCount != input.UpRulesCount || (this.UpRulesCount != null && !this.UpRulesCount.Equals(input.UpRulesCount))) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.UpRulesCount != null) hashCode = hashCode * 59 + this.UpRulesCount.GetHashCode();
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                return hashCode;
            }
        }
    }
}
