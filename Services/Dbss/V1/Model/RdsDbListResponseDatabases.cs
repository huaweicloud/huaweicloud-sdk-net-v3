using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RdsDbListResponseDatabases 
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 实例状态。 - BUILD：表示实例正在创建。 - ACTIVE：表示实例正常。 - FAILED：表示实例异常。 - FROZEN：表示实例冻结。 - MODIFYING：表示实例正在扩容。 - REBOOTING：表示实例正在重启。 - RESTORING：表示实例正在恢复。 - MODIFYING INSTANCE TYPE：表示实例正在转主备。 - SWITCHOVER：表示实例正在主备切换。 - MIGRATING：表示实例正在迁移。 - BACKING UP：表示实例正在进行备份。 - MODIFYING DATABASE PORT：表示实例正在修改数据库端口。 - STORAGE FULL：表示实例磁盘空间满。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// rds实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 数据库类型 - MYSQL：MySql - ORACLE：Oracle - POSTGRESQL：PostgreSQL - SQLSERVER：SQL Server - DAMENG：DAMENG - TAURUS：TaurusDB - DWS：GaussDB DWS - KINGBASE：KINGBASE - MARIADB：MariaDB - GAUSSDBOPENGAUSS：GaussDB/openGauss
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 是否支持免agent审计
        /// </summary>
        [JsonProperty("is_supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RdsDbListResponseDatabases {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  isSupported: ").Append(IsSupported).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RdsDbListResponseDatabases);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RdsDbListResponseDatabases input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.IsSupported != input.IsSupported || (this.IsSupported != null && !this.IsSupported.Equals(input.IsSupported))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.IsSupported != null) hashCode = hashCode * 59 + this.IsSupported.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
