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
    /// 测试计划操作历史详情
    /// </summary>
    public class TestPlanJournalDetail 
    {

        /// <summary>
        /// 测试计划基础信息变更，包括计划名称，测试类型，计划处理者、版本号、关联迭代、开始日期、截至日期、描述
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttributeChange> Updated { get; set; }

        /// <summary>
        /// 测试计划资源的添加记录（工作项或者测试用例）
        /// </summary>
        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndId> Added { get; set; }

        /// <summary>
        /// 测试计划资源的移除记录（工作项或者测试用例）
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndId> Deleted { get; set; }

        /// <summary>
        /// 表明该条变更记录的具体变更类型，例如测试用例（testCase），需求（issue）
        /// </summary>
        [JsonProperty("journalized_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JournalizedType { get; set; }

        /// <summary>
        /// 表明该条变更记录属于基础信息变更还是资源（需求添加移除、用例添加移除）变更
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestPlanJournalDetail {\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  added: ").Append(Added).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  journalizedType: ").Append(JournalizedType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPlanJournalDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestPlanJournalDetail input)
        {
            if (input == null) return false;
            if (this.Updated != input.Updated || (this.Updated != null && input.Updated != null && !this.Updated.SequenceEqual(input.Updated))) return false;
            if (this.Added != input.Added || (this.Added != null && input.Added != null && !this.Added.SequenceEqual(input.Added))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && input.Deleted != null && !this.Deleted.SequenceEqual(input.Deleted))) return false;
            if (this.JournalizedType != input.JournalizedType || (this.JournalizedType != null && !this.JournalizedType.Equals(input.JournalizedType))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Added != null) hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.JournalizedType != null) hashCode = hashCode * 59 + this.JournalizedType.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
