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
    public class ShowTableMetaInfoResponse : SdkResponse
    {

        /// <summary>
        /// 要版本升级的批量实例。
        /// </summary>
        [JsonProperty("table_meta_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableMetaInfo> TableMetaInfos { get; set; }

        /// <summary>
        /// 数据表名称
        /// </summary>
        [JsonProperty("table_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TableNames { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("database_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatabaseNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTableMetaInfoResponse {\n");
            sb.Append("  tableMetaInfos: ").Append(TableMetaInfos).Append("\n");
            sb.Append("  tableNames: ").Append(TableNames).Append("\n");
            sb.Append("  databaseNames: ").Append(DatabaseNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTableMetaInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTableMetaInfoResponse input)
        {
            if (input == null) return false;
            if (this.TableMetaInfos != input.TableMetaInfos || (this.TableMetaInfos != null && input.TableMetaInfos != null && !this.TableMetaInfos.SequenceEqual(input.TableMetaInfos))) return false;
            if (this.TableNames != input.TableNames || (this.TableNames != null && input.TableNames != null && !this.TableNames.SequenceEqual(input.TableNames))) return false;
            if (this.DatabaseNames != input.DatabaseNames || (this.DatabaseNames != null && input.DatabaseNames != null && !this.DatabaseNames.SequenceEqual(input.DatabaseNames))) return false;

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
                if (this.TableMetaInfos != null) hashCode = hashCode * 59 + this.TableMetaInfos.GetHashCode();
                if (this.TableNames != null) hashCode = hashCode * 59 + this.TableNames.GetHashCode();
                if (this.DatabaseNames != null) hashCode = hashCode * 59 + this.DatabaseNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
