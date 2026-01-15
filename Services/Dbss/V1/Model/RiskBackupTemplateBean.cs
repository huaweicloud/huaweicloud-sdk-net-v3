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
    public class RiskBackupTemplateBean 
    {

        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbId { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("db_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIp { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// 配置ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 状态 - 0：关闭 - 1：开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskBackupTemplateBean {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  dbIp: ").Append(DbIp).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RiskBackupTemplateBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RiskBackupTemplateBean input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.DbIp != input.DbIp || (this.DbIp != null && !this.DbIp.Equals(input.DbIp))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.DbIp != null) hashCode = hashCode * 59 + this.DbIp.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
