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
    /// 数据库对象采集请求体
    /// </summary>
    public class QuerySelectObjectInfoReq 
    {

        /// <summary>
        /// 查询指定库的信息。
        /// </summary>
        [JsonProperty("db_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbNames { get; set; }

        /// <summary>
        /// 查询对象信息类型，取值： - source：查询源库对象信息。 - modified：查询已选择的（已同步的和未下发的）对象信息。 - synchronized：查询已同步的（已下发的）对象信息 ， 使用场景在任务处于全量中或者增量中。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 是否强制刷新。取值： - true：是，表示从源库重新查询。 - false：否，表示从已缓存中数据查询。
        /// </summary>
        [JsonProperty("is_refresh", NullValueHandling = NullValueHandling.Ignore)]
        public string IsRefresh { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySelectObjectInfoReq {\n");
            sb.Append("  dbNames: ").Append(DbNames).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isRefresh: ").Append(IsRefresh).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuerySelectObjectInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySelectObjectInfoReq input)
        {
            if (input == null) return false;
            if (this.DbNames != input.DbNames || (this.DbNames != null && input.DbNames != null && !this.DbNames.SequenceEqual(input.DbNames))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.IsRefresh != input.IsRefresh || (this.IsRefresh != null && !this.IsRefresh.Equals(input.IsRefresh))) return false;

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
                if (this.DbNames != null) hashCode = hashCode * 59 + this.DbNames.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsRefresh != null) hashCode = hashCode * 59 + this.IsRefresh.GetHashCode();
                return hashCode;
            }
        }
    }
}
