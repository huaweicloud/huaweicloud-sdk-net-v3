using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGaussMySqlEngineVersionResponse : SdkResponse
    {

        /// <summary>
        /// 数据库版本信息列表
        /// </summary>
        [JsonProperty("datastores", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlEngineVersionInfo> Datastores { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlEngineVersionResponse {\n");
            sb.Append("  datastores: ").Append(Datastores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlEngineVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlEngineVersionResponse input)
        {
            if (input == null) return false;
            if (this.Datastores != input.Datastores || (this.Datastores != null && input.Datastores != null && !this.Datastores.SequenceEqual(input.Datastores))) return false;

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
                if (this.Datastores != null) hashCode = hashCode * 59 + this.Datastores.GetHashCode();
                return hashCode;
            }
        }
    }
}
