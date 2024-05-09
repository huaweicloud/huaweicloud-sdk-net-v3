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
    /// 内容对比详情信息体。
    /// </summary>
    public class ContentDiffDetailVO 
    {

        /// <summary>
        /// 源库KEY值。
        /// </summary>
        [JsonProperty("source_key_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceKeyValue { get; set; }

        /// <summary>
        /// 目标库KEY值。
        /// </summary>
        [JsonProperty("target_key_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetKeyValue { get; set; }

        /// <summary>
        /// 查询源库SQL。
        /// </summary>
        [JsonProperty("source_select_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSelectSql { get; set; }

        /// <summary>
        /// 查询目标库SQL。
        /// </summary>
        [JsonProperty("target_select_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSelectSql { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDiffDetailVO {\n");
            sb.Append("  sourceKeyValue: ").Append(SourceKeyValue).Append("\n");
            sb.Append("  targetKeyValue: ").Append(TargetKeyValue).Append("\n");
            sb.Append("  sourceSelectSql: ").Append(SourceSelectSql).Append("\n");
            sb.Append("  targetSelectSql: ").Append(TargetSelectSql).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentDiffDetailVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentDiffDetailVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceKeyValue == input.SourceKeyValue ||
                    this.SourceKeyValue != null &&
                    input.SourceKeyValue != null &&
                    this.SourceKeyValue.SequenceEqual(input.SourceKeyValue)
                ) && 
                (
                    this.TargetKeyValue == input.TargetKeyValue ||
                    this.TargetKeyValue != null &&
                    input.TargetKeyValue != null &&
                    this.TargetKeyValue.SequenceEqual(input.TargetKeyValue)
                ) && 
                (
                    this.SourceSelectSql == input.SourceSelectSql ||
                    (this.SourceSelectSql != null &&
                    this.SourceSelectSql.Equals(input.SourceSelectSql))
                ) && 
                (
                    this.TargetSelectSql == input.TargetSelectSql ||
                    (this.TargetSelectSql != null &&
                    this.TargetSelectSql.Equals(input.TargetSelectSql))
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
                if (this.SourceKeyValue != null)
                    hashCode = hashCode * 59 + this.SourceKeyValue.GetHashCode();
                if (this.TargetKeyValue != null)
                    hashCode = hashCode * 59 + this.TargetKeyValue.GetHashCode();
                if (this.SourceSelectSql != null)
                    hashCode = hashCode * 59 + this.SourceSelectSql.GetHashCode();
                if (this.TargetSelectSql != null)
                    hashCode = hashCode * 59 + this.TargetSelectSql.GetHashCode();
                return hashCode;
            }
        }
    }
}
