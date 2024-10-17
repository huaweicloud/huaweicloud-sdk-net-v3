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
    /// Request Object
    /// </summary>
    public class ShowRestoreTablesRequest 
    {

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID，严格匹配UUID规则。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份时间点，时间戳格式。  通过[查询可恢复时间段](https://support.huaweicloud.com/api-gaussdbformysql/ShowBackupRestoreTime.html)获取。
        /// </summary>
        [SDKProperty("restore_time", IsQuery = true)]
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 是否是最新库表。 - true：是最新库表。 - false：是恢复时间点库表。
        /// </summary>
        [SDKProperty("last_table_info", IsQuery = true)]
        [JsonProperty("last_table_info", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTableInfo { get; set; }

        /// <summary>
        /// 数据库名称，模糊匹配。
        /// </summary>
        [SDKProperty("database_name", IsQuery = true)]
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 表名称，模糊匹配。
        /// </summary>
        [SDKProperty("table_name", IsQuery = true)]
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRestoreTablesRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  lastTableInfo: ").Append(LastTableInfo).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRestoreTablesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRestoreTablesRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;
            if (this.LastTableInfo != input.LastTableInfo || (this.LastTableInfo != null && !this.LastTableInfo.Equals(input.LastTableInfo))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.LastTableInfo != null) hashCode = hashCode * 59 + this.LastTableInfo.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
