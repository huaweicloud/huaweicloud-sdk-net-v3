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
    /// 删除对象列信息请求体
    /// </summary>
    public class DeleteColumnInfoReq 
    {

        /// <summary>
        /// 列所属表的id
        /// </summary>
        [JsonProperty("table_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TableIds { get; set; }

        /// <summary>
        /// 列所属schema的id
        /// </summary>
        [JsonProperty("schema_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SchemaIds { get; set; }

        /// <summary>
        /// 列所属库的id
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteColumnInfoReq {\n");
            sb.Append("  tableIds: ").Append(TableIds).Append("\n");
            sb.Append("  schemaIds: ").Append(SchemaIds).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteColumnInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteColumnInfoReq input)
        {
            if (input == null) return false;
            if (this.TableIds != input.TableIds || (this.TableIds != null && input.TableIds != null && !this.TableIds.SequenceEqual(input.TableIds))) return false;
            if (this.SchemaIds != input.SchemaIds || (this.SchemaIds != null && input.SchemaIds != null && !this.SchemaIds.SequenceEqual(input.SchemaIds))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && input.DbIds != null && !this.DbIds.SequenceEqual(input.DbIds))) return false;

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
                if (this.TableIds != null) hashCode = hashCode * 59 + this.TableIds.GetHashCode();
                if (this.SchemaIds != null) hashCode = hashCode * 59 + this.SchemaIds.GetHashCode();
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
