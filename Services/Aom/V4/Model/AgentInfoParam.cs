using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentInfoParam 
    {

        /// <summary>
        /// 分页查询的起始页数（第几页）。默认值：1。
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long? Page { get; set; }

        /// <summary>
        /// 每页查询数量，默认20。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageSize { get; set; }

        /// <summary>
        /// ecs ID列表信息。
        /// </summary>
        [JsonProperty("ecs_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EcsIdList { get; set; }

        /// <summary>
        /// agent ID列表信息。
        /// </summary>
        [JsonProperty("agent_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AgentIdList { get; set; }

        /// <summary>
        /// cmdb  ID列表信息。
        /// </summary>
        [JsonProperty("coc_cmdb_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CocCmdbIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentInfoParam {\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ecsIdList: ").Append(EcsIdList).Append("\n");
            sb.Append("  agentIdList: ").Append(AgentIdList).Append("\n");
            sb.Append("  cocCmdbIdList: ").Append(CocCmdbIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentInfoParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentInfoParam input)
        {
            if (input == null) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.EcsIdList != input.EcsIdList || (this.EcsIdList != null && input.EcsIdList != null && !this.EcsIdList.SequenceEqual(input.EcsIdList))) return false;
            if (this.AgentIdList != input.AgentIdList || (this.AgentIdList != null && input.AgentIdList != null && !this.AgentIdList.SequenceEqual(input.AgentIdList))) return false;
            if (this.CocCmdbIdList != input.CocCmdbIdList || (this.CocCmdbIdList != null && input.CocCmdbIdList != null && !this.CocCmdbIdList.SequenceEqual(input.CocCmdbIdList))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.EcsIdList != null) hashCode = hashCode * 59 + this.EcsIdList.GetHashCode();
                if (this.AgentIdList != null) hashCode = hashCode * 59 + this.AgentIdList.GetHashCode();
                if (this.CocCmdbIdList != null) hashCode = hashCode * 59 + this.CocCmdbIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
