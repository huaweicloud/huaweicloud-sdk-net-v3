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
    public class AuditAgentRespoonseAgents 
    {

        /// <summary>
        /// agent ID
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// agent 类型 - DB: 数据库端 - APP: 应用端
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentType { get; set; }

        /// <summary>
        /// agent OS
        /// </summary>
        [JsonProperty("agent_os", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentOs { get; set; }

        /// <summary>
        /// agent安装节点IP
        /// </summary>
        [JsonProperty("agent_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentIp { get; set; }

        /// <summary>
        /// 内存阈值
        /// </summary>
        [JsonProperty("mem_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemThreshold { get; set; }

        /// <summary>
        /// cpu阈值
        /// </summary>
        [JsonProperty("cpu_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuThreshold { get; set; }

        /// <summary>
        /// agent状态 - 1：开启 - 0：关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// agent网卡
        /// </summary>
        [JsonProperty("agent_nic", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentNic { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据流量抓取状态 - 1：运行中 - 2：休眠中 - 3：已停止 - 4：异常
        /// </summary>
        [JsonProperty("datacap_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatacapStatus { get; set; }

        /// <summary>
        /// agent安装地址
        /// </summary>
        [JsonProperty("agent_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentUrl { get; set; }

        /// <summary>
        /// 是否CCE场景
        /// </summary>
        [JsonProperty("universal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Universal { get; set; }

        /// <summary>
        /// sha256值
        /// </summary>
        [JsonProperty("sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditAgentRespoonseAgents {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("  agentOs: ").Append(AgentOs).Append("\n");
            sb.Append("  agentIp: ").Append(AgentIp).Append("\n");
            sb.Append("  memThreshold: ").Append(MemThreshold).Append("\n");
            sb.Append("  cpuThreshold: ").Append(CpuThreshold).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  agentNic: ").Append(AgentNic).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  datacapStatus: ").Append(DatacapStatus).Append("\n");
            sb.Append("  agentUrl: ").Append(AgentUrl).Append("\n");
            sb.Append("  universal: ").Append(Universal).Append("\n");
            sb.Append("  sha256: ").Append(Sha256).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditAgentRespoonseAgents);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditAgentRespoonseAgents input)
        {
            if (input == null) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.AgentType != input.AgentType || (this.AgentType != null && !this.AgentType.Equals(input.AgentType))) return false;
            if (this.AgentOs != input.AgentOs || (this.AgentOs != null && !this.AgentOs.Equals(input.AgentOs))) return false;
            if (this.AgentIp != input.AgentIp || (this.AgentIp != null && !this.AgentIp.Equals(input.AgentIp))) return false;
            if (this.MemThreshold != input.MemThreshold || (this.MemThreshold != null && !this.MemThreshold.Equals(input.MemThreshold))) return false;
            if (this.CpuThreshold != input.CpuThreshold || (this.CpuThreshold != null && !this.CpuThreshold.Equals(input.CpuThreshold))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AgentNic != input.AgentNic || (this.AgentNic != null && !this.AgentNic.Equals(input.AgentNic))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.DatacapStatus != input.DatacapStatus || (this.DatacapStatus != null && !this.DatacapStatus.Equals(input.DatacapStatus))) return false;
            if (this.AgentUrl != input.AgentUrl || (this.AgentUrl != null && !this.AgentUrl.Equals(input.AgentUrl))) return false;
            if (this.Universal != input.Universal || (this.Universal != null && !this.Universal.Equals(input.Universal))) return false;
            if (this.Sha256 != input.Sha256 || (this.Sha256 != null && !this.Sha256.Equals(input.Sha256))) return false;

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
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.AgentType != null) hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                if (this.AgentOs != null) hashCode = hashCode * 59 + this.AgentOs.GetHashCode();
                if (this.AgentIp != null) hashCode = hashCode * 59 + this.AgentIp.GetHashCode();
                if (this.MemThreshold != null) hashCode = hashCode * 59 + this.MemThreshold.GetHashCode();
                if (this.CpuThreshold != null) hashCode = hashCode * 59 + this.CpuThreshold.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AgentNic != null) hashCode = hashCode * 59 + this.AgentNic.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.DatacapStatus != null) hashCode = hashCode * 59 + this.DatacapStatus.GetHashCode();
                if (this.AgentUrl != null) hashCode = hashCode * 59 + this.AgentUrl.GetHashCode();
                if (this.Universal != null) hashCode = hashCode * 59 + this.Universal.GetHashCode();
                if (this.Sha256 != null) hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                return hashCode;
            }
        }
    }
}
