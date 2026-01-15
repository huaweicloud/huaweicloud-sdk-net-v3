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
    /// 连接响应体。
    /// </summary>
    public class ConnectionResp 
    {

        /// <summary>
        /// 连接ID。
        /// </summary>
        [JsonProperty("connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// 连接名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 连接创建时间，格式为时间戳。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 连接类型。 取值：mysql - postgresql - mongodb - oracle
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public BaseEndpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public CloudVpcInfo Vpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointSslConfig Ssl { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionResp {\n");
            sb.Append("  connectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  ssl: ").Append(Ssl).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionResp input)
        {
            if (input == null) return false;
            if (this.ConnectionId != input.ConnectionId || (this.ConnectionId != null && !this.ConnectionId.Equals(input.ConnectionId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.Config != input.Config || (this.Config != null && !this.Config.Equals(input.Config))) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Vpc != input.Vpc || (this.Vpc != null && !this.Vpc.Equals(input.Vpc))) return false;
            if (this.Ssl != input.Ssl || (this.Ssl != null && !this.Ssl.Equals(input.Ssl))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.ConnectionId != null) hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Config != null) hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Vpc != null) hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Ssl != null) hashCode = hashCode * 59 + this.Ssl.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
