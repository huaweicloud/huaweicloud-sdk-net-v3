using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSearchCriteriasBody 
    {

        /// <summary>
        /// 快速查询字段
        /// </summary>
        [JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)]
        public string Criteria { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// 创建快速查询名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 查询类型 原始日志：ORIGINALLOG 可视化日志: VISUALIZATION
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSearchCriteriasBody {\n");
            sb.Append("  criteria: ").Append(Criteria).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSearchCriteriasBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSearchCriteriasBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Criteria == input.Criteria ||
                    (this.Criteria != null &&
                    this.Criteria.Equals(input.Criteria))
                ) && 
                (
                    this.EpsId == input.EpsId ||
                    (this.EpsId != null &&
                    this.EpsId.Equals(input.EpsId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
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
                if (this.Criteria != null)
                    hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                if (this.EpsId != null)
                    hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
