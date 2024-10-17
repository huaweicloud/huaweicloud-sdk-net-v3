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
    /// 数据库信息
    /// </summary>
    public class DataBase 
    {

        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 添加的数据库类型： - MYSQL - ORACLE - POSTGRESQL - SQLSERVER - DAMENG - TAURUS - DWS - KINGBASE - GAUSSDBOPENGAUSS - GREENPLUM - HIGHGO - SHENTONG - GBASE8A - GBASE8S - GBASEXDM - MONGODB - DDS
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 数据库字符集 - GBK - UTF8
        /// </summary>
        [JsonProperty("charset", NullValueHandling = NullValueHandling.Ignore)]
        public string Charset { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 数据库操作系统
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 实例状态 - ON :开启 - OFF : 关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据库实例名
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 数据库的运行状态 - ACTIVE - SHUTOFF - ERROR
        /// </summary>
        [JsonProperty("audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// agent的唯一ID
        /// </summary>
        [JsonProperty("agent_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AgentUrl { get; set; }

        /// <summary>
        /// 数据库分类 - RDS: 表示RDS数据库 - ECS:自建数据库
        /// </summary>
        [JsonProperty("db_classification", NullValueHandling = NullValueHandling.Ignore)]
        public string DbClassification { get; set; }

        /// <summary>
        /// rds实例审计开关状态不匹配。当数据库审计开启且rds侧日志上传开关关闭时该字段为true。
        /// </summary>
        [JsonProperty("rds_audit_switch_mismatch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RdsAuditSwitchMismatch { get; set; }

        /// <summary>
        /// RDS数据库的ID。
        /// </summary>
        [JsonProperty("rds_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsId { get; set; }

        /// <summary>
        /// RDS数据库信息。
        /// </summary>
        [JsonProperty("rds_obj_info", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsObjInfo { get; set; }

        /// <summary>
        /// DWS数据库信息。
        /// </summary>
        [JsonProperty("dws_obj_info", NullValueHandling = NullValueHandling.Ignore)]
        public string DwsObjInfo { get; set; }

        /// <summary>
        /// 云数据库信息，该字段已废弃。
        /// </summary>
        [JsonProperty("clouddb_obj_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ClouddbObjInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBase {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  charset: ").Append(Charset).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  auditStatus: ").Append(AuditStatus).Append("\n");
            sb.Append("  agentUrl: ").Append(AgentUrl).Append("\n");
            sb.Append("  dbClassification: ").Append(DbClassification).Append("\n");
            sb.Append("  rdsAuditSwitchMismatch: ").Append(RdsAuditSwitchMismatch).Append("\n");
            sb.Append("  rdsId: ").Append(RdsId).Append("\n");
            sb.Append("  rdsObjInfo: ").Append(RdsObjInfo).Append("\n");
            sb.Append("  dwsObjInfo: ").Append(DwsObjInfo).Append("\n");
            sb.Append("  clouddbObjInfo: ").Append(ClouddbObjInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataBase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataBase input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Charset != input.Charset || (this.Charset != null && !this.Charset.Equals(input.Charset))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.AuditStatus != input.AuditStatus || (this.AuditStatus != null && !this.AuditStatus.Equals(input.AuditStatus))) return false;
            if (this.AgentUrl != input.AgentUrl || (this.AgentUrl != null && input.AgentUrl != null && !this.AgentUrl.SequenceEqual(input.AgentUrl))) return false;
            if (this.DbClassification != input.DbClassification || (this.DbClassification != null && !this.DbClassification.Equals(input.DbClassification))) return false;
            if (this.RdsAuditSwitchMismatch != input.RdsAuditSwitchMismatch || (this.RdsAuditSwitchMismatch != null && !this.RdsAuditSwitchMismatch.Equals(input.RdsAuditSwitchMismatch))) return false;
            if (this.RdsId != input.RdsId || (this.RdsId != null && !this.RdsId.Equals(input.RdsId))) return false;
            if (this.RdsObjInfo != input.RdsObjInfo || (this.RdsObjInfo != null && !this.RdsObjInfo.Equals(input.RdsObjInfo))) return false;
            if (this.DwsObjInfo != input.DwsObjInfo || (this.DwsObjInfo != null && !this.DwsObjInfo.Equals(input.DwsObjInfo))) return false;
            if (this.ClouddbObjInfo != input.ClouddbObjInfo || (this.ClouddbObjInfo != null && !this.ClouddbObjInfo.Equals(input.ClouddbObjInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Charset != null) hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.AuditStatus != null) hashCode = hashCode * 59 + this.AuditStatus.GetHashCode();
                if (this.AgentUrl != null) hashCode = hashCode * 59 + this.AgentUrl.GetHashCode();
                if (this.DbClassification != null) hashCode = hashCode * 59 + this.DbClassification.GetHashCode();
                if (this.RdsAuditSwitchMismatch != null) hashCode = hashCode * 59 + this.RdsAuditSwitchMismatch.GetHashCode();
                if (this.RdsId != null) hashCode = hashCode * 59 + this.RdsId.GetHashCode();
                if (this.RdsObjInfo != null) hashCode = hashCode * 59 + this.RdsObjInfo.GetHashCode();
                if (this.DwsObjInfo != null) hashCode = hashCode * 59 + this.DwsObjInfo.GetHashCode();
                if (this.ClouddbObjInfo != null) hashCode = hashCode * 59 + this.ClouddbObjInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
