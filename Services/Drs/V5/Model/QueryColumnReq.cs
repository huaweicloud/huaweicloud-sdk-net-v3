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
    /// 是否从源库获取最新的列信息
    /// </summary>
    public class QueryColumnReq 
    {

        /// <summary>
        /// 是否从Node获取最新的列信息
        /// </summary>
        [JsonProperty("is_force_refresh", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForceRefresh { get; set; }

        /// <summary>
        /// 指定数据库表信息
        /// </summary>
        [JsonProperty("db_object_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectDbTableObjectInfo> DbObjectInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryColumnReq {\n");
            sb.Append("  isForceRefresh: ").Append(IsForceRefresh).Append("\n");
            sb.Append("  dbObjectInfos: ").Append(DbObjectInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryColumnReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryColumnReq input)
        {
            if (input == null) return false;
            if (this.IsForceRefresh != input.IsForceRefresh || (this.IsForceRefresh != null && !this.IsForceRefresh.Equals(input.IsForceRefresh))) return false;
            if (this.DbObjectInfos != input.DbObjectInfos || (this.DbObjectInfos != null && input.DbObjectInfos != null && !this.DbObjectInfos.SequenceEqual(input.DbObjectInfos))) return false;

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
                if (this.IsForceRefresh != null) hashCode = hashCode * 59 + this.IsForceRefresh.GetHashCode();
                if (this.DbObjectInfos != null) hashCode = hashCode * 59 + this.DbObjectInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
